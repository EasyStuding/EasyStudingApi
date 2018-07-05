using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using EasyStudingRepositories.DbContext;
using EasyStudingRepositories.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingRepositories.Repositories
{
    public class ExecutorRepository : IExecutorRepository
    {
        #region Repositories from db.

        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Skill> _skillRepository;
        private readonly IRepository<UserSkill> _userSkillRepository;

        #endregion

        private readonly EasyStudingContext _context;

        public ExecutorRepository(EasyStudingContext context)
        {
            _context = context;
            _userRepository = new UniversalRepository<User>(_context);
            _orderRepository = new UniversalRepository<Order>(_context);
            _skillRepository = new UniversalRepository<Skill>(_context);
            _userSkillRepository = new UniversalRepository<UserSkill>(_context);
        }

        /// <summary>
        ///   Get orders, classified by CustomerEducation and CustomerCity. 
        ///   If orders have executor, then not return them.
        /// </summary>
        /// <param name="education">Education of customer.</param>
        /// <param name="country">Country of customer.</param>
        /// <param name="city">City of customer.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Orders sorted by city and education.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>
        /// <exception cref="System.ArgumentNullException">When result not found.</exception>

        public async Task<IQueryable<Order>> GetOrders(string education, string country, string region, string city, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var users = _userRepository.GetAll().Where(u =>
                u.Education.Contains(education)
                && u.Country.Contains(country)
                && u.Region.Contains(region)
                && u.City.Contains(city))
                ?? throw new ArgumentNullException();

            return _orderRepository.GetAll().Where(o =>
                o.ExecutorId == null
                && users.Any(u =>
                    u.Id == o.CustomerId))
                ?? throw new ArgumentNullException();
        }

        /// <summary>
        ///   Get order by id.
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<Order> GetOrder(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            return await _orderRepository.GetAsync(id);
        }

        /// <summary>
        ///   Open transaction to get rights to perform order.
        /// </summary>
        /// <param name="id">Id of order to get rights for this order.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.InvalidOperationException">When order have executor.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Id of executor != currentUserId 
        /// or current user not executor.</exception>

        public async Task<Order> GetTheRightsToPerformOrder(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var order = await _orderRepository.GetAsync(id);

            order.ExecutorId = (order.ExecutorId == null
                && order.InProgress == false)
                ? currentUserId
                : throw new InvalidOperationException();

            return await _orderRepository.EditAsync(order);
        }

        /// <summary>
        ///   Close execute of order from Executor.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///   Requested order.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor 
        /// or executor of order not current user.</exception>

        public async Task<Order> CloseOrder(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var order = await _orderRepository.GetAsync(id);

            order.IsClosedByExecutor = order.ExecutorId == currentUserId
                ? true
                : throw new UnauthorizedAccessException();

            order.IsCompleted = order.IsClosedByCustomer == true
                ? true
                : false;

            return await _orderRepository.EditAsync(order);
        }

        /// <summary>
        ///   Add skill to executor profile.
        /// </summary>
        /// <param name="id">Id of skill what executor want to add.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Added skill.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<Skill> AddSkill(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var skill = await _skillRepository.GetAsync(id);

            await _userSkillRepository.AddAsync(new UserSkill()
            {
                SkillId = skill.Id,
                UserId = currentUserId
            });

            return skill;
        }

        /// <summary>
        ///   Romove skill from executor profile.
        /// </summary>
        /// <param name="id">Id of skill what executor want to remove.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Removed skill.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>
        /// <exception cref="System.ArgumentNullException">Result not found.</exception>

        public async Task<Skill> RemoveSkill(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var skill = await _skillRepository.GetAsync(id);

            var userSkill = _userSkillRepository
                .GetAll()
                .FirstOrDefault(us => us.SkillId == skill.Id
                    && us.UserId == currentUserId)
                ?? throw new ArgumentNullException();

            await _userSkillRepository.RemoveAsync(userSkill.Id);

            return skill;
        }
    }
}

using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using EasyStudingModels.Extensions;
using System.Linq;
using System.Threading.Tasks;
using EasyStudingRepositories.Extensions;
using System;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request. In this service you need currentUserId to check permissons and create/close orders, role of user not contains in identity.
    public class ExecutorService: IExecutorService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Skill> _skillRepository;
        private readonly IRepository<UserSkill> _userSkillRepository;

        public ExecutorService(
            IRepository<User> userRepository,
            IRepository<Order> orderRepository,
            IRepository<Skill> skillRepository,
            IRepository<UserSkill> userSkillRepository
            )
        {
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _skillRepository = skillRepository;
            _userSkillRepository = userSkillRepository;
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

        public async Task<IQueryable<Order>> GetOrders(string education, string country, string region, string city, long currentUserId)
        {
            //(await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var users = _userRepository.GetAll().Where(u =>
                u.Education.Contains(education.ConvertToValidModel())
                && u.Country.Contains(country.ConvertToValidModel())
                && u.Region.Contains(region.ConvertToValidModel())
                && u.City.Contains(city.ConvertToValidModel()))
                ?? throw new ArgumentNullException();

            return _orderRepository.GetAll().Where(o =>
                o.ExecutorId != null
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

        public async Task<Order> CloseOrder(long id, long currentUserId)
        {
            (await _userRepository.GetAsync(currentUserId)).CheckExecutorSubscription();

            var order = await _orderRepository.GetAsync(id);

            order.IsClosedByExecutor = (order.ExecutorId == currentUserId
                && order.InProgress == true)
                ? true
                : throw new UnauthorizedAccessException();

            order.IsCompleted = order.IsClosedByCustomer == true
                ? true
                : false;

            return await _orderRepository.EditAsync(order);
        }


        
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

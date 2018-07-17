using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;
using EasyStudingModels.Extensions;
using EasyStudingModels;
using System;
using EasyStudingServices.Extensions;

namespace EasyStudingServices.Services
{
    public class ModeratorService: IModeratorService
    {
        #region Initialize repositories.

        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Attachment> _attachmentRepository;
        private readonly IRepository<Skill> _skillRepository;
        private readonly IRepository<UserSkill> _userSkillRepository;
        private readonly IRepository<OrderSkill> _orderSkillRepository;

        public ModeratorService(IRepository<User> userRepository, 
            IRepository<Order> orderRepository,
            IRepository<Attachment> attachmentRepository,
            IRepository<Skill> skillRepository,
            IRepository<UserSkill> userSkillRepository,
            IRepository<OrderSkill> orderSkillRepository)
        {
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _attachmentRepository = attachmentRepository;
            _userSkillRepository = userSkillRepository;
            _skillRepository = skillRepository;
            _orderSkillRepository = orderSkillRepository;
        }

        #endregion

        /// <summary>
        ///   Grant moderator rights to user.
        /// </summary>
        /// <param name="id">Id of user to grant rights of moderator.</param>
        /// <returns>
        ///    User.
        /// </returns>
        /// <exception cref="System.ArgumentException">Invalid params.</exception>

        public async Task<User> GrantRights(long userId, string permisions)
        {
            var user = await _userRepository.GetAsync(userId);
            
            user.Role = permisions.Equals(Defines.Roles.MODERATOR, StringComparison.OrdinalIgnoreCase)
                    ? Defines.Roles.MODERATOR
                    : permisions.Equals(Defines.Roles.USER, StringComparison.OrdinalIgnoreCase)
                    ? Defines.Roles.USER
                    : throw new ArgumentException();

            return (await _userRepository.EditAsync(user)).GetSkillsToUser(_userSkillRepository, _skillRepository);
        }

        /// <summary>
        ///   Restrict access to data.
        /// </summary>
        /// <param name="id">Id of user to ban.</param>
        /// <returns>
        ///    Banned user.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result not found.</exception>
        /// <exception cref="System.InvalidOperationException">When user moderator or admin.</exception>

        public async Task<User> BanUser(long id)
        {
            const int monthToBan = 3;

            var user = await _userRepository.GetAsync(id);

            user.BanExpiresDate = user.Role.Equals(Defines.Roles.ADMIN)
                || user.Role.Equals(Defines.Roles.MODERATOR)
                ? throw new InvalidOperationException()
                : DateTime.Now.AddMonths(monthToBan);

            return (await _userRepository.EditAsync(user)).GetSkillsToUser(_userSkillRepository, _skillRepository);
        }

        /// <summary>
        ///   Give access to data.
        /// </summary>
        /// <param name="id">Id of user to remove ban.</param>
        /// <returns>
        ///    Unbanned user.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result not found.</exception>

        public async Task<User> RemoveBanOfUser(long id)
        {
            var user = await _userRepository.GetAsync(id);

            user.BanExpiresDate = DateTime.Now;

            return (await _userRepository.EditAsync(user)).GetSkillsToUser(_userSkillRepository, _skillRepository);
        }

        /// <summary>
        ///   Close order.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <returns>
        ///    Closed order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result not found.</exception>

        public async Task<OrderToReturn> CloseOrder(long id)
        {
            var order = await _orderRepository.GetAsync(id);

            order.IsCompleted = true;

            return ConvertOrder(await _orderRepository.EditAsync(order));
        }

        /// <summary>
        ///   Get orders, classified by CustomerEducation and CustomerCity. 
        /// </summary>
        /// <param name="education">Education of customer.</param>
        /// <param name="country">Country of customer.</param>
        /// <param name="city">City of customer.</param>
        /// <returns>
        ///    Orders sorted by city and education.
        /// </returns>

        public IQueryable<OrderToReturn> GetOrders(string education, string country, string region, string city, string skills)
        {
            var users = _userRepository.GetAll().Where(u =>
                  u.Education.Contains(education.ConvertToValidModel())
                  && u.Country.Contains(country.ConvertToValidModel())
                  && u.Region.Contains(region.ConvertToValidModel())
                  && u.City.Contains(city.ConvertToValidModel()));

            return _orderRepository.GetAll().Where(o =>
                users.Any(u =>
                    u.Id == o.CustomerId
                    || u.Id == o.ExecutorId))
                .ToList()
                .Select(o => ConvertOrder(o))
                .Where(o => o.Skills.Any(s => skills.Contains(s.Name)))
                .AsQueryable();   
        }

        /// <summary>
        ///   Get order by id.
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result not found.</exception>

        public async Task<OrderToReturn> GetOrder(long id)
        {
            return ConvertOrder(await _orderRepository.GetAsync(id));
        }

        private OrderToReturn ConvertOrder(Order order)
        {
            return order
                .ConvertOrderToReturn(order.GetAttachmentsToOrder(_attachmentRepository),
                order.GetSkillsToOrder(_orderSkillRepository, _skillRepository));
        }

    }
}

using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;
using EasyStudingModels.Extensions;
using EasyStudingModels;
using System;
using EasyStudingServices.Extensions;
using EasyStudingRepositories.DbContext;

namespace EasyStudingServices.Services
{
    public class ModeratorService: IModeratorService
    {
        #region Initialize repositories.

        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Attachment> _attachmentRepository;
        private readonly EasyStudingContext _context;

        public ModeratorService(IRepository<User> userRepository, 
            IRepository<Order> orderRepository,
            IRepository<Attachment> attachmentRepository,
            EasyStudingContext context)
        {
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _attachmentRepository = attachmentRepository;
            _context = context;
        }

        #endregion

        /// <summary>
        ///   Grant moderator rights to user.
        /// </summary>
        /// <param name="id">Id of user to grant rights of moderator.</param>
        /// <returns>
        ///    User.
        /// </returns>

        public async Task<User> GrantModeratorRights(long userId)
        {
            var user = await _userRepository.GetAsync(userId);

            user.Role = Defines.Roles.MODERATOR;

            return (await _userRepository.EditAsync(user)).GetSkillsToUser(_context);
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
            var user = await _userRepository.GetAsync(id);

            user.BanExpiresDate = user.Role.Equals(Defines.Roles.ADMIN)
                || user.Role.Equals(Defines.Roles.MODERATOR)
                ? throw new InvalidOperationException()
                : DateTime.Now.AddMonths(3);

            return (await _userRepository.EditAsync(user)).GetSkillsToUser(_context);
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

            return (await _userRepository.EditAsync(user)).GetSkillsToUser(_context);
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
        /// <exception cref="System.ArgumentNullException">When result not found.</exception>

        public IQueryable<OrderToReturn> GetOrders(string education, string country, string region, string city)
        {
            var users = _userRepository.GetAll().Where(u =>
                  u.Education.Contains(education.ConvertToValidModel())
                  && u.Country.Contains(country.ConvertToValidModel())
                  && u.Region.Contains(region.ConvertToValidModel())
                  && u.City.Contains(city.ConvertToValidModel()))
                  ?? throw new ArgumentNullException();

            return _orderRepository.GetAll().Where(o =>
                users.Any(u =>
                    u.Id == o.CustomerId
                    || u.Id == o.ExecutorId))
                .ToList()
                .Select(o => ConvertOrder(o))
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
                order.GetSkillsToOrder(_context));
        }

    }
}

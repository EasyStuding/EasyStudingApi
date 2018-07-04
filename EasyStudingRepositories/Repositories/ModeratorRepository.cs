using EasyStudingInterfaces.Repositories;
using EasyStudingModels;
using EasyStudingModels.Models;
using EasyStudingRepositories.DbContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingRepositories.Repositories
{
    public class ModeratorRepository : IModeratorRepository
    {
        #region Repositories from db.
        
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Order> _orderRepository;

        #endregion

        private readonly EasyStudingContext _context;

        public ModeratorRepository(EasyStudingContext context)
        {
            _context = context;
            _userRepository = new UniversalRepository<User>(_context);
            _orderRepository = new UniversalRepository<Order>(_context);
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

            return await _userRepository.EditAsync(user);
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

            return await _userRepository.EditAsync(user);
        }

        /// <summary>
        ///   Close order.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <returns>
        ///    Closed order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result not found.</exception>

        public async Task<Order> CloseOrder(long id)
        {
            var order = await _orderRepository.GetAsync(id);
            
            order.IsCompleted = true;

            return await _orderRepository.EditAsync(order);
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

        public IQueryable<Order> GetOrders(string education, string country, string region, string city)
        {
            var users = _userRepository.GetAll().Where(u =>
                u.Education.Contains(education)
                && u.Country.Contains(country)
                && u.Region.Contains(region)
                && u.City.Contains(city))
                ?? throw new ArgumentNullException();

            return _orderRepository.GetAll().Where(o => 
                users.Any(u => 
                    u.Id == o.CustomerId 
                    || u.Id == o.ExecutorId))
                ?? throw new ArgumentNullException();
        }

        /// <summary>
        ///   Get order by id.
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result not found.</exception>

        public async Task<Order> GetOrder(long id)
        {
            return await _orderRepository.GetAsync(id);
        }
    }
}

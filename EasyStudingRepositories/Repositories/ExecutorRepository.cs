using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using EasyStudingRepositories.DbContext;
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

        #endregion

        private readonly EasyStudingContext _context;

        public ExecutorRepository(EasyStudingContext context)
        {
            _context = context;
            _userRepository = new UniversalRepository<User>(_context);
            _orderRepository = new UniversalRepository<Order>(_context);
            _skillRepository = new UniversalRepository<Skill>(_context);
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

        public async Task<IQueryable<Order>> GetOrders(string education, string country, string region, string city, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get order by id.
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Id of executor != currentUserId or current user not executor.</exception>

        public async Task<Order> GetOrder(long id, long currentUserId)
        {
            throw new Exception();
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
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<Order> GetTheRightsToPerformOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Close execute of order from Executor.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///   Requested order.
        /// </returns>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<Order> CloseOrder(long id, long currentUserId)
        {
            throw new Exception();
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
            throw new Exception();
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

        public async Task<Skill> RemoveSkill(long id, long currentUserId)
        {
            throw new Exception();
        }
    }
}

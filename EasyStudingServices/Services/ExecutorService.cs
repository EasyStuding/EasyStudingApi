using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request. In this service you need currentUserId to check permissons and create/close orders, role of user not contains in identity.
    public class ExecutorService: IExecutorService
    {
        private readonly IExecutorRepository _executorRepository;

        public ExecutorService(IExecutorRepository executorRepository)
        {
            _executorRepository = executorRepository;
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
        /// <exception cref="System.ArgumentException">When one of params invalid.</exception>

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

        public async Task<Skill> RemoveSkill(long id, long currentUserId)
        {
            throw new Exception();
        }
    }
}

using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request. In this service you need currentUserId to check permissons and create/close orders, role of user not contains in identity.
    public class ExecutorService: IExecutorService
    {
        //TODO: initialize repositories;

        /// <summary>
        ///   Get orders, classified by CustomerEducation and CustomerCity. 
        ///   If orders have executor, then not return them.
        /// </summary>
        /// <param name="education">Education of customer.</param>
        /// <param name="city">City of customer.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Orders sorted by city and education.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When education or city not found.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<IQueryable<ApiOrderDetailsModel>> GetOrderDetailsModels(ApiEducationModel education, City city, long currentUserId)
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

        public async Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id, long currentUserId)
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
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When result not found.</exception>
        /// <exception cref="System.InvalidOperationException">When order have executor.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<ApiOrderDetailsModel> GetTheRightsToPerformOrder(long id, long currentUserId)
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
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When result not found.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<ApiOrderDetailsModel> CloseOrder(long id, long currentUserId)
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
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When result not found.</exception>
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
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When result not found.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<Skill> RemoveSkill(long id, long currentUserId)
        {
            throw new Exception();
        }
    }
}

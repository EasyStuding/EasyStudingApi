using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;
using EasyStudingModels.Extensions;

namespace EasyStudingServices.Services
{
    public class ModeratorService: IModeratorService
    {
        private readonly IModeratorRepository _moderatorRepository;

        public ModeratorService(IModeratorRepository moderatorRepository)
        {
            _moderatorRepository = moderatorRepository;
        }

        /// <summary>
        ///   Grant moderator rights to user.
        /// </summary>
        /// <param name="id">Id of user to grant rights of moderator.</param>
        /// <returns>
        ///    User.
        /// </returns>

        public async Task<User> GrantModeratorRights(long userId)
        {
            return await _moderatorRepository.GrantModeratorRights(userId);
        }

        /// <summary>
        ///   Restrict access to data.
        /// </summary>
        /// <param name="id">Id of user to ban.</param>
        /// <returns>
        ///    Banned user.
        /// </returns>

        public async Task<User> BanUser(long id)
        {
            return await _moderatorRepository.BanUser(id);
        }

        /// <summary>
        ///   Give access to data.
        /// </summary>
        /// <param name="id">Id of user to remove ban.</param>
        /// <returns>
        ///    Unbanned user.
        /// </returns>

        public async Task<User> RemoveBanOfUser(long id)
        {
            return await _moderatorRepository.RemoveBanOfUser(id);
        }

        /// <summary>
        ///   Close order.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <returns>
        ///    Closed order.
        /// </returns>

        public async Task<Order> CloseOrder(long id)
        {
            return await _moderatorRepository.CloseOrder(id);
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

        public IQueryable<Order> GetOrders(string education, string country, string region, string city)
        {
            return _moderatorRepository.GetOrders(education.ConvertToValidModel(),
                country.ConvertToValidModel(),
                region.ConvertToValidModel(),
                city.ConvertToValidModel());
        }

        /// <summary>
        ///   Get order by id.
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>

        public async Task<Order> GetOrder(long id)
        {
            return await _moderatorRepository.GetOrder(id);
        }

    }
}

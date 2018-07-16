using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Services
{
    public interface IModeratorService
    {
        Task<User> GrantModeratorRights(long userId);

        Task<User> BanUser(long id);

        Task<User> RemoveBanOfUser(long id);

        Task<OrderToReturn> CloseOrder(long id);

        IQueryable<OrderToReturn> GetOrders(string education, string country, string region, string city, string skills);

        Task<OrderToReturn> GetOrder(long id);
    }
}

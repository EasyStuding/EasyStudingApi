using EasyStudingModels.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IModeratorController
    {
        Task<User> GrantModeratorRights(long userId);

        Task<User> BanUser(long id);

        Task<User> RemoveBanOfUser(long id);

        Task<OrderToReturn> CloseOrder(long id);

        IQueryable<OrderToReturn> GetOrders(string education, string country, string region, string city);

        Task<OrderToReturn> GetOrder(long id);

        Task<FileResult> GetLogs(string date);
    }
}

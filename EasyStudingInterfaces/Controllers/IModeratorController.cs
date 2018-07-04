using EasyStudingModels.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IModeratorController
    {
        Task<User> BanUser(long id);

        Task<User> RemoveBanOfUser(long id);

        Task<Order> CloseOrder(long id);

        IQueryable<Order> GetOrders(string education, string country, string region, string city);

        Task<Order> GetOrder(long id);

        Task<FileResult> GetLogs(string date);
    }
}

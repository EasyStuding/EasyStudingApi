using EasyStudingModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Repositories
{
    public interface IModeratorRepository
    {
        Task<User> BanUser(long id);

        Task<User> RemoveBanOfUser(long id);

        Task<Order> CloseOrder(long id);

        IQueryable<Order> GetOrders(string education, string country, string region, string city);

        Task<Order> GetOrder(long id);
    }
}

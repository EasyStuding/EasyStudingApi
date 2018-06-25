using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IExecutorController
    {
        Task<IQueryable<Order>> GetOrders(string education, string country, string city);

        Task<Order> GetOrder(long id);

        Task<Order> GetTheRightsToPerformOrder(long id);

        Task<Order> CloseOrder(long id);

        Task<Skill> AddSkill(long id);

        Task<Skill> RemoveSkill(long id);
    }
}

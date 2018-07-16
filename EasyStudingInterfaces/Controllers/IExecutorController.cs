using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IExecutorController
    {
        Task<IQueryable<OrderToReturn>> GetOrders(string education, string country, string region, string city, string skills);

        Task<OrderToReturn> GetOrder(long id);

        Task<OrderToReturn> GetTheRightsToPerformOrder(long id);

        Task<OrderToReturn> CloseOrder(long id);

        Task<Skill> AddSkill(long id);

        Task<Skill> RemoveSkill(long id);
    }
}

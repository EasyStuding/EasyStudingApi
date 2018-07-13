using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Services
{
    public interface IExecutorService
    {
        Task<IQueryable<OrderToReturn>> GetOrders(string education, string country, string region, string city, long currentUserId);

        Task<OrderToReturn> GetOrder(long id, long currentUserId);

        Task<OrderToReturn> GetTheRightsToPerformOrder(long id, long currentUserId);

        Task<OrderToReturn> CloseOrder(long id, long currentUserId);

        Task<Skill> AddSkill(long id, long currentUserId);

        Task<Skill> RemoveSkill(long id, long currentUserId);
    }
}

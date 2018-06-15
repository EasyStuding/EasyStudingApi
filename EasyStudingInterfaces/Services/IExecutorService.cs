using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Services
{
    public interface IExecutorService
    {
        Task<IQueryable<ApiOrderDetailsModel>> GetOrderDetailsModels(ApiEducationModel education, City city, long currentUserId);

        Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id, long currentUserId);

        Task<ApiOrderDetailsModel> GetTheRightsToPerformOrder(long id, long currentUserId);

        Task<ApiOrderDetailsModel> CloseOrder(long id, long currentUserId);

        Task<Skill> AddSkill(long id, long currentUserId);

        Task<Skill> RemoveSkill(long id, long currentUserId);
    }
}

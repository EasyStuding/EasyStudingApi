using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IExecutorController
    {
        Task<IQueryable<ApiOrderDetailsModel>> GetOrderDetailsModels(ApiEducationModel education, City city);

        Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id);

        Task<ApiOrderDetailsModel> GetTheRightsToPerformOrder(long id);

        Task<ApiOrderDetailsModel> StartExecuteOrder(long id);

        Task<ApiOrderDetailsModel> CloseOrder(long id);

        Task<Skill> AddSkill(long id);

        Task<Skill> RemoveSkill(long id);
    }
}

using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;

namespace EasyStudingInterfaces.Services
{
    public interface IExecutorService
    {
        IQueryable<ApiOrderDetailsModel> GetOrderDetailsModels(ApiEducationModel education, City city);

        ApiOrderDetailsModel GetApiOrderDetailsModel(long id);

        ApiOrderDetailsModel GetTheRightsToPerformOrder(long id, long currentUserId);

        ApiOrderDetailsModel StartExecuteOrder(long id, long currentUserId);

        ApiOrderDetailsModel CloseOrder(long id);

        Skill AddSkill(long id, long currentUserId);

        Skill RemoveSkill(long id, long currentUserId);
    }
}

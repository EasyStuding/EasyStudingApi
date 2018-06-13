using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;

namespace EasyStudingInterfaces.Controllers
{
    public interface IExecutorController
    {
        IQueryable<ApiOrderDetailsModel> GetOrderDetailsModels(ApiEducationModel education, City city);

        ApiOrderDetailsModel GetApiOrderDetailsModel(long id);

        ApiOrderDetailsModel GetTheRightsToPerformOrder(long id);

        ApiOrderDetailsModel StartExecuteOrder(long id);

        ApiOrderDetailsModel CloseOrder(long id);

        Skill AddSkill(long id);

        Skill RemoveSkill(long id);
    }
}

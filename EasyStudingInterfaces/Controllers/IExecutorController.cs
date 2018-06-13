using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface IExecutorController
    {
        ApiOrderDetailsModel GetTheRightsToPerformOrder(long orderid);

        ApiOrderDetailsModel StartExecuteOrder(long orderid);

        ApiOrderDetailsModel CloseOrder(long orderid);

        Skill AddSkill(long skillid);

        Skill RemoveSkill(long skillid);
    }
}

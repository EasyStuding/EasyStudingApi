using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface IExecutorController
    {
        ApiOrderDetails GetTheRightsToPerformOrder(long orderid);

        ApiOrderDetails StartExecuteOrder(long orderid);

        ApiOrderDetails CloseOrder(long orderid);

        Skill AddSkill(long skillid);

        Skill RemoveSkill(long skillid);
    }
}

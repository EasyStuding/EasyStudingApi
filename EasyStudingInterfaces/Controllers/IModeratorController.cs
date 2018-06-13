using EasyStudingModels.ApiModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface IModeratorController
    {
        ApiUserInformation BanUser(long id);

        ApiUserInformation RemoveBanOfUser(long id);

        ApiOrderDetails CloseOrder(long id);
    }
}

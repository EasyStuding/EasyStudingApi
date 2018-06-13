using EasyStudingModels.ApiModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface IModeratorController
    {
        ApiUserInformationModel BanUser(long id);

        ApiUserInformationModel RemoveBanOfUser(long id);

        ApiOrderDetailsModel CloseOrder(long id);
    }
}

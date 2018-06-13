namespace EasyStudingInterfaces.Controllers
{
    public interface IModeratorController
    {
        bool BanUser(long id);

        bool RemoveBanOfUser(long id);

        bool CloseOrder(long id);
    }
}

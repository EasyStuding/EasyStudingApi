namespace EasyStudingInterfaces.Services
{
    public interface IModeratorService
    {
        bool BanUser(long id);

        bool RemoveBanOfUser(long id);

        bool CloseOrder(long id);
    }
}

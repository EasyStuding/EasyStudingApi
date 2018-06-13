namespace EasyStudingInterfaces.Services
{
    public interface IExecutorService
    {
        bool ObtainTheRightsToPerformOrder(long orderid);

        bool StartExecuteOrder(long orderid);

        bool CloseOrder(long orderid);

        bool AddSkill(long skillid);

        bool RemoveSkill(long skillid);
    }
}

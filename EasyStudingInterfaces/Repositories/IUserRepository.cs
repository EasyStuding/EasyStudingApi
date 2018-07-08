using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Repositories
{
    public interface IUserRepository
    {
        IQueryable<User> GetUsers(string education, string country, string region, string city);

        Task<User> GetUser(long id);

        Task<IQueryable<OrderToReturn>> GetOrders(long currentUserId);

        Task<OrderToReturn> GetOrder(long id, long currentUserId);

        IQueryable<User> GetExecutors(string education, string country, string region, string city);

        Task<IQueryable<FileToReturnModel>> GetOpenSourceAttachments(long ownerOpenSourceId, long currentUserId);

        Task<FileToReturnModel> OpenSourceDownloadFile(long fileId, long currentUserId);

        Task<User> ValidateEmail(string validationCode, long currentUserId);

        Task<bool> ChangePassword(string oldPassword, string newPassword, long currentUserId);

        Task<User> EditProfile(User user, long currentUserId);

        Task<User> AddPictureProfile(FileToAddModel file, string currentUrl, long currentUserId);

        Task<User> RemovePictureProfile(long currentUserId);

        Task<User> BuySubscription(string name, long currentUserId);

        Task<FileToReturnModel> AddFileToOpenSource(FileToAddModel file, string currentUrl, long currentUserId);

        Task<FileToReturnModel> RemoveFileFromOpenSource(long id, long currentUserId);

        Task<OrderToReturn> AddOrder(OrderToAdd order, string currentUrl, long currentUserId);

        Task<OrderToReturn> StartExecuteOrder(long id, long executorUserId, long currentUserId);

        Task<OrderToReturn> RefuseExecutor(long id, long currentUserId);

        Task<OrderToReturn> CloseOrder(long id, long currentUserId);

        Task<Review> AddReview(Review review, long currentUserId);
    }
}

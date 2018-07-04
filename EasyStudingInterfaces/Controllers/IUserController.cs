using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IUserController
    {
        Task<IQueryable<User>> GetUsers(string education, string country, string region, string city);

        Task<User> GetUser(long id);

        Task<IQueryable<Order>> GetOrders();

        Task<Order> GetOrder(long id);

        Task<IQueryable<User>> GetExecutors(string education, string country, string region, string city);

        Task<IQueryable<FileToReturnModel>> GetOpenSourceAttachments(long ownerOpenSourceId);

        Task<FileToReturnModel> OpenSourceDownloadFile(long fileId);

        Task<bool> ValidateEmail(string validationCode);

        Task<bool> ChangePassword(string oldPassword, string newPassword);

        Task<User> EditProfile(User user);

        Task<FileToReturnModel> AddPictureProfile(FileToAddModel file);

        Task<FileToReturnModel> RemovePictureProfile(long id);

        Task<User> BuySubscription(string name);

        Task<FileToReturnModel> AddFileToOpenSource(FileToAddModel file);

        Task<FileToReturnModel> RemoveFileFromOpenSource(long id);

        Task<Order> AddOrder(Order order);

        Task<Order> StartExecuteOrder(long id, long executorUserId);

        Task<Order> CloseOrder(long id);

        Task<Review> AddReview(Review review);
    }
}

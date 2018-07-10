using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IUserController
    {
        IQueryable<User> GetUsers(string education, string country, string region, string city);

        Task<User> GetUser(long id);

        Task<IQueryable<OrderToReturn>> GetOrders();

        Task<OrderToReturn> GetOrder(long id);

        IQueryable<User> GetExecutors(string education, string country, string region, string city);

        Task<IQueryable<FileToReturnModel>> GetOpenSourceAttachments(long ownerOpenSourceId);

        Task<FileToReturnModel> OpenSourceDownloadFile(long fileId);

        Task<bool> ChangePassword(string oldPassword, string newPassword);

        Task<User> EditProfile(User user);

        Task<User> ValidateEmail(ValidateModel validateModel);

        Task<bool> GetValidationCode();

        Task<User> AddPictureProfile(FileToAddModel file);

        Task<User> RemovePictureProfile();

        Task<User> BuySubscription(string name);

        Task<FileToReturnModel> AddFileToOpenSource(FileToAddModel file);

        Task<FileToReturnModel> RemoveFileFromOpenSource(long id);

        Task<OrderToReturn> AddOrder(OrderToAdd order);

        Task<OrderToReturn> StartExecuteOrder(long id, long executorUserId);

        Task<OrderToReturn> RefuseExecutor(long id);

        Task<OrderToReturn> CloseOrder(long id);

        Task<Review> AddReview(Review review);
    }
}

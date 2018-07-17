using EasyStudingModels.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IUserController
    {
        IQueryable<Skill> GetSkills();

        Task<Skill> GetSkill(long id);

        IQueryable<User> GetUsers(string education, string country, string region, string city, string skills);

        Task<User> GetUser(long id);

        Task<IQueryable<OrderToReturn>> GetOrders();

        Task<OrderToReturn> GetOrder(long id);

        IQueryable<User> GetExecutors(string education, string country, string region, string city, string skills);

        Task<IQueryable<FileToReturnModel>> GetOpenSourceAttachments(long ownerOpenSourceId);

        Task<FileResult> OpenSourceDownloadFile(long fileId);

        Task<bool> ChangePassword(string oldPassword, string newPassword);

        Task<User> EditProfile(User user);

        Task<User> ValidateEmail(ValidateModel validateModel);

        Task<bool> GenerateValidationCode();

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

        Task<OrderToReturn> AddOrderView(long id);

        Task<OrderToReturn> AddOrderRequest(long id);
    }
}

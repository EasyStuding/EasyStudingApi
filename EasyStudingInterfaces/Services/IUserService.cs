using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Services
{
    public interface IUserService
    {
        Task<IQueryable<ApiUserDescriptionModel>> GetApiUserDescriptionModels(ApiEducationModel education, City city);

        Task<ApiUserDescriptionModel> GetApiUserDescriptionModel(long id);

        Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels(long currentUserId);

        Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id, long currentUserId);

        Task<IQueryable<ApiUserDescriptionModel>> GetSubscriptionExecutors(ApiEducationModel education, City city);

        Task<IQueryable<ApiFileToReturnModel>> GetOpenSourceAttachments(long openSourceId, long currentUserId);

        Task<ApiFileToReturnModel> OpenSourceDownloadFile(long fileId, long currentUserId);

        Task<bool> ValidateEmail(string validationCode, long currentUserId);

        Task<bool> ChangePassword(string oldPassword, string newPassword, long currentUserId);

        Task<ApiUserDescriptionModel> EditProfile(ApiUserDescriptionModel description, long currentUserId);

        Task<ApiFileToReturnModel> AddPictureProfile(ApiFileToAddModel file, long currentUserId);

        Task<ApiFileToReturnModel> RemovePictureProfile(long id, long currentUserId);

        Task<Cost> RequestToBuySubscription(Cost cost, long currentUserId);

        Task<Cost> CompleteBuySubcription(Cost cost, long currentUserId);

        Task<ApiFileToReturnModel> AddFileToOpenSource(ApiFileToAddModel file, long currentUserId);

        Task<ApiFileToReturnModel> RemoveFileFromOpenSource(long id, long currentUserId);

        Task<ApiOrderDetailsModel> AddOrder(ApiOrderDetailsModel order, long currentUserId);

        Task<ApiOrderDetailsModel> StartExecuteOrder(long id, long currentUserId, long executorUserId);

        Task<ApiOrderDetailsModel> CloseOrder(long id, long currentUserId);

        Task<ApiReviewModel> AddReview(ApiReviewModel review, long currentUserId);
    }
}

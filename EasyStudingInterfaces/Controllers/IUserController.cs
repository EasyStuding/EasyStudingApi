using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IUserController
    {
        Task<IQueryable<ApiUserDescriptionModel>> GetApiUserDescriptionModels(ApiEducationModel education, City city);

        Task<ApiUserDescriptionModel> GetApiUserDescriptionModel(long id);

        Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels();

        Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id);

        Task<IQueryable<Subscription>> GetSubscriptionExecutors(ApiEducationModel education, City city);

        Task<bool> ChangePassword(string oldPassword, string newPassword);

        Task<ApiUserDescriptionModel> EditProfile(ApiUserDescriptionModel description);

        Task<ApiFileToReturnModel> AddPictureProfile(ApiFileToAddModel file);

        Task<ApiFileToReturnModel> EditPictureProfile(ApiFileToAddModel file);

        Task<ApiFileToReturnModel> RemovePictureProfile(long id);

        Task<Cost> RequestToBuySubscription(Cost cost);

        Task<Cost> CompleteBuySubcription(Cost cost);

        Task<ApiFileToReturnModel> AddFileToOpenSource(ApiFileToAddModel file);

        Task<ApiFileToReturnModel> RemoveFileFromOpenSource(long id);

        Task<ApiOrderDetailsModel> AddOrder(ApiOrderDetailsModel order);

        Task<ApiOrderDetailsModel> StartExecuteOrder(long id);

        Task<ApiOrderDetailsModel> CloseOrder(long id);

        Task<ApiReviewModel> AddReview(ApiReviewModel review);
    }
}

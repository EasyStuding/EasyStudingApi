using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IUserController
    {
        Task<IQueryable<ApiUserInformationModel>> GetApiUserInformationModels(ApiEducationModel education, City city);

        Task<ApiUserInformationModel> GetApiUserInformationModel(long id);

        Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels();

        Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id);

        Task<IQueryable<SubscriptionExecutor>> GetSubscriptionExecutors(ApiEducationModel education, City city);

        Task<SubscriptionExecutor> GetSubscriptionExecutor(long id);

        Task<bool> ChangePassword(string oldPassword, string newPassword);

        Task<ApiUserDescriptionModel> EditProfile(ApiUserDescriptionModel description);

        Task<ApiFileToReturnModel> AddPictureProfile(ApiFileToAddModel file);

        Task<ApiFileToReturnModel> EditPictureProfile(ApiFileToAddModel file);

        Task<ApiFileToReturnModel> RemovePictureProfile(long id);

        Task<Cost> RequestToBuySubscription(Cost cost);

        Task<Cost> CompleteBuySubcription(Cost cost);

        Task<ApiFileToReturnModel> AddFileToOpenSource(ApiFileToAddModel file);

        Task<ApiOrderDetailsModel> AddOrder(ApiOrderDetailsModel order);

        Task<ApiOrderDetailsModel> CloseOrder(long id);

        Task<ApiReviewModel> AddReview(ApiReviewModel review);
    }
}

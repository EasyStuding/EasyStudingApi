using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;

namespace EasyStudingInterfaces.Controllers
{
    public interface IUserController
    {
        IQueryable<ApiUserInformationModel> GetApiUserInformationModels(ApiEducationModel education, City city);

        ApiUserInformationModel GetApiUserInformationModel(long id);

        IQueryable<ApiOrderDetailsModel> GetApiOrderDetailsModels();

        ApiOrderDetailsModel GetApiOrderDetailsModel(long id);

        IQueryable<SubscriptionExecutor> GetSubscriptionExecutors(ApiEducationModel education, City city);

        SubscriptionExecutor GetSubscriptionExecutor(long id);

        bool ChangePassword(string oldPassword, string newPassword);

        ApiUserDescriptionModel EditProfile(ApiUserDescriptionModel description);

        ApiFileToReturnModel AddPictureProfile(ApiFileToAddModel file);

        ApiFileToReturnModel EditPictureProfile(ApiFileToAddModel file);

        ApiFileToReturnModel RemovePictureProfile(long id);

        Cost RequestToBuySubscription(Cost cost);

        Cost CompleteBuySubcription(Cost cost);

        ApiFileToReturnModel AddFileToOpenSource(ApiFileToAddModel file);

        ApiOrderDetailsModel AddOrder(ApiOrderDetailsModel order);

        ApiOrderDetailsModel CloseOrder(long id);

        ApiReviewModel AddReview(ApiReviewModel review);
    }
}

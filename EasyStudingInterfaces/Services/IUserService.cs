using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;

namespace EasyStudingInterfaces.Services
{
    public interface IUserService
    {
        IQueryable<ApiUserInformationModel> GetApiUserInformationModels(ApiEducationModel education, City city);

        ApiUserInformationModel GetApiUserInformationModel(long id);

        IQueryable<ApiOrderDetailsModel> GetApiOrderDetailsModels(long currentUserId);

        ApiOrderDetailsModel GetApiOrderDetailsModel(long id, long currentUserId);

        IQueryable<SubscriptionExecutor> GetSubscriptionExecutors(ApiEducationModel education, City city);

        SubscriptionExecutor GetSubscriptionExecutor(long id);

        bool ChangePassword(string oldPassword, string newPassword, long currentUserId);

        ApiUserDescriptionModel EditProfile(ApiUserDescriptionModel description, long currentUserId);

        ApiFileToReturnModel AddPictureProfile(ApiFileToAddModel file, long currentUserId);

        ApiFileToReturnModel EditPictureProfile(ApiFileToAddModel file, long currentUserId);

        ApiFileToReturnModel RemovePictureProfile(long id, long currentUserId);

        Cost RequestToBuySubscription(Cost cost, long currentUserId);

        Cost CompleteBuySubcription(Cost cost, long currentUserId);

        ApiFileToReturnModel AddFileToOpenSource(ApiFileToAddModel file, long currentUserId);

        ApiOrderDetailsModel AddOrder(ApiOrderDetailsModel order, long currentUserId);

        ApiOrderDetailsModel CloseOrder(long id, long currentUserId);

        ApiReviewModel AddReview(ApiReviewModel review, long currentUserId);
    }
}

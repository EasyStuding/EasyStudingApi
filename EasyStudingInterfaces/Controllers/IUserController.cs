using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface IUserController
    {
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

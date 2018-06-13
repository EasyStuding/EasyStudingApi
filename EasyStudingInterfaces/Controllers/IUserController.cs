using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface IUserController
    {
        bool ChangePassword(string oldPassword, string newPassword);

        ApiUserDescription EditProfile(ApiUserDescription description);

        ApiFileToReturn AddPictureProfile(ApiFileToAdd file);

        ApiFileToReturn EditPictureProfile(ApiFileToAdd file);

        ApiFileToReturn RemovePictureProfile(long id);

        Cost RequestToBuySubscription(Cost cost);

        Cost CompleteBuySubcription(Cost cost);

        ApiFileToReturn AddFileToOpenSource(ApiFileToAdd file);

        ApiOrderDetails AddOrder(ApiOrderDetails order);

        ApiOrderDetails CloseOrder(long id);

        ApiReview AddReview(ApiReview review);
    }
}

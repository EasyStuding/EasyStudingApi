using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Services
{
    public interface IUserService
    {
        bool ChangePassword(string oldPassword, string newPassword);

        ApiUserDescriptionModel EditProfile(ApiUserDescriptionModel description);

        UserPicture AddPictureProfile(ApiAddFile file);

        UserPicture EditPictureProfile(ApiAddFile file);

        bool RemovePictureProfile(long id);

        bool RequestToBuySubscription(Cost cost);

        bool CompleteBuySubcription(Cost cost);

        bool AddFileToOpenSource(ApiAddFile file);

        bool AddOrder(ApiOrderDetailsModel order);

        bool CloseOrder(long id);

        bool AddReview(ApiReviewModel review);
    }
}

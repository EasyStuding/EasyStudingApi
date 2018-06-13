using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Services
{
    public interface IUserService
    {
        bool ChangePassword(string oldPassword, string newPassword);

        ApiUserDescription EditProfile(ApiUserDescription description);

        UserPicture AddPictureProfile(ApiAddFile file);

        UserPicture EditPictureProfile(ApiAddFile file);

        bool RemovePictureProfile(long id);

        bool RequestToBuySubscription(Cost cost);

        bool CompleteBuySubcription(Cost cost);

        bool AddFileToOpenSource(ApiAddFile file);

        bool AddOrder(ApiOrderDetails order);

        bool CloseOrder(long id);

        bool AddReview(ApiReview review);
    }
}

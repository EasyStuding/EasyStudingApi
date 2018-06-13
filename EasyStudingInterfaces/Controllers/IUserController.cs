using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface IUserController
    {
        bool ChangePassword(string oldPassword, string newPassword);

        ApiUserDescription EditProfile(ApiUserDescription description);

        UserPicture AddPictureProfile(ApiFile file);

        UserPicture EditPictureProfile(ApiFile file);

        bool RemovePictureProfile(long id);

        bool RequestToBuySubscription(Cost cost);

        bool CompleteBuySubcription(Cost cost);

		bool AddFileToOpenSource(ApiFile file);

        bool AddOrder(ApiOrderDetails order);

        bool CloseOrder(long id);

        bool AddReview(ApiReview review);
    }
}

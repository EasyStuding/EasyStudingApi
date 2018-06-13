using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request.
    public class UserService: IUserService
    {
        //TODO: initialize repositories;

        public IQueryable<ApiUserInformationModel> GetApiUserInformationModels(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        public ApiUserInformationModel GetApiUserInformationModel(long id)
        {
            throw new Exception();
        }

        public IQueryable<ApiOrderDetailsModel> GetApiOrderDetailsModels(long currentUserId)
        {
            throw new Exception();
        }

        public ApiOrderDetailsModel GetApiOrderDetailsModel(long id, long currentUserId)
        {
            throw new Exception();
        }

        public IQueryable<SubscriptionExecutor> GetSubscriptionExecutors(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        public SubscriptionExecutor GetSubscriptionExecutor(long id)
        {
            throw new Exception();
        }

        public bool ChangePassword(string oldPassword, string newPassword, long currentUserId)
        {
            throw new Exception();
        }

        public ApiUserDescriptionModel EditProfile(ApiUserDescriptionModel description, long currentUserId)
        {
            throw new Exception();
        }

        public ApiFileToReturnModel AddPictureProfile(ApiFileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        public ApiFileToReturnModel EditPictureProfile(ApiFileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        public ApiFileToReturnModel RemovePictureProfile(long id, long currentUserId)
        {
            throw new Exception();
        }

        public Cost RequestToBuySubscription(Cost cost, long currentUserId)
        {
            throw new Exception();
        }

        public Cost CompleteBuySubcription(Cost cost, long currentUserId)
        {
            throw new Exception();
        }

        public ApiFileToReturnModel AddFileToOpenSource(ApiFileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        public ApiOrderDetailsModel AddOrder(ApiOrderDetailsModel order, long currentUserId)
        {
            throw new Exception();
        }

        public ApiOrderDetailsModel CloseOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        public ApiReviewModel AddReview(ApiReviewModel review, long currentUserId)
        {
            throw new Exception();
        }
    }
}

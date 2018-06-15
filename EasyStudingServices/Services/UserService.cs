using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request.
    public class UserService: IUserService
    {
        //TODO: initialize repositories;

        public async Task<IQueryable<ApiUserInformationModel>> GetApiUserInformationModels(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        public async Task<ApiUserInformationModel> GetApiUserInformationModel(long id)
        {
            throw new Exception();
        }

        public async Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels(long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<IQueryable<SubscriptionExecutor>> GetSubscriptionExecutors(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        public async Task<SubscriptionExecutor> GetSubscriptionExecutor(long id)
        {
            throw new Exception();
        }

        public async Task<bool> ChangePassword(string oldPassword, string newPassword, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiUserDescriptionModel> EditProfile(ApiUserDescriptionModel description, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiFileToReturnModel> AddPictureProfile(ApiFileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiFileToReturnModel> EditPictureProfile(ApiFileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiFileToReturnModel> RemovePictureProfile(long id, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<Cost> RequestToBuySubscription(Cost cost, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<Cost> CompleteBuySubcription(Cost cost, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiFileToReturnModel> AddFileToOpenSource(ApiFileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiOrderDetailsModel> AddOrder(ApiOrderDetailsModel order, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiOrderDetailsModel> StartExecuteOrder(long id, long currentUserId, long executorUserId)
        {
            throw new Exception();
        }

        public async Task<ApiOrderDetailsModel> CloseOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiReviewModel> AddReview(ApiReviewModel review, long currentUserId)
        {
            throw new Exception();
        }
    }
}

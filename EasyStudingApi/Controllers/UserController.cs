using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/User/[action]")]
    public class UserController : Controller, IUserController
    {
        private readonly IUserService Service;

        public UserController(IUserService service)
        {
            Service = service;
        }

        [HttpGet]
        // * - host.
        // */api/user/GetApiUserInformationModels
        public async Task<IQueryable<ApiUserDescriptionModel>> GetApiUserDescriptionModels([FromBody]ApiEducationModel education, [FromBody]City city)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/user/GetApiUserInformationModel
        public async Task<ApiUserDescriptionModel> GetApiUserDescriptionModel(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/user/GetApiOrderDetailsModels
        public async Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels()
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/user/GetApiOrderDetailsModel
        public async Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/user/GetSubscriptionExecutors
        public async Task<IQueryable<Subscription>> GetSubscriptionExecutors([FromBody]ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/user/GetSubscriptionExecutor
        public async Task<Subscription> GetSubscriptionExecutor(long id)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/user/ChangePassword
        public async Task<bool> ChangePassword(string oldPassword, string newPassword)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/user/EditProfile
        public async Task<ApiUserDescriptionModel> EditProfile([FromBody]ApiUserDescriptionModel description)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/AddPictureProfile
        public async Task<ApiFileToReturnModel> AddPictureProfile([FromBody]ApiFileToAddModel file)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/user/EditPictureProfile
        public async Task<ApiFileToReturnModel> EditPictureProfile([FromBody]ApiFileToAddModel file)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/user/RemovePictureProfile
        public async Task<ApiFileToReturnModel> RemovePictureProfile(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/RequestToBuySubscription
        public async Task<Cost> RequestToBuySubscription([FromBody]Cost cost)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/CompleteBuySubcription
        public async Task<Cost> CompleteBuySubcription([FromBody]Cost cost)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/AddFileToOpenSource
        public async Task<ApiFileToReturnModel> AddFileToOpenSource([FromBody]ApiFileToAddModel file)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/AddFileToOpenSource
        public async Task<ApiFileToReturnModel> RemoveFileFromOpenSource(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/AddOrder
        public async Task<ApiOrderDetailsModel> AddOrder([FromBody]ApiOrderDetailsModel order)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/CloseOrder
        public async Task<ApiOrderDetailsModel> CloseOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/StartExecuteOrder
        public async Task<ApiOrderDetailsModel> StartExecuteOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/AddReview
        public async Task<ApiReviewModel> AddReview([FromBody]ApiReviewModel review)
        {
            throw new Exception();
        }
    }
}
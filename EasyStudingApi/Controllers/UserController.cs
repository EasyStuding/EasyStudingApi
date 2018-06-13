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
    //TODO: add attributes from body.
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
        public IQueryable<ApiUserInformationModel> GetApiUserInformationModels(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/user/GetApiUserInformationModel
        public ApiUserInformationModel GetApiUserInformationModel(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/user/GetApiOrderDetailsModels
        public IQueryable<ApiOrderDetailsModel> GetApiOrderDetailsModels()
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/user/GetApiOrderDetailsModel
        public ApiOrderDetailsModel GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/user/GetSubscriptionExecutors
        public IQueryable<SubscriptionExecutor> GetSubscriptionExecutors(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/user/GetSubscriptionExecutor
        public SubscriptionExecutor GetSubscriptionExecutor(long id)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/user/ChangePassword
        public bool ChangePassword(string oldPassword, string newPassword)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/user/EditProfile
        public ApiUserDescriptionModel EditProfile(ApiUserDescriptionModel description)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/AddPictureProfile
        public ApiFileToReturnModel AddPictureProfile(ApiFileToAddModel file)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/user/EditPictureProfile
        public ApiFileToReturnModel EditPictureProfile(ApiFileToAddModel file)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/user/RemovePictureProfile
        public ApiFileToReturnModel RemovePictureProfile(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/RequestToBuySubscription
        public Cost RequestToBuySubscription(Cost cost)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/CompleteBuySubcription
        public Cost CompleteBuySubcription(Cost cost)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/AddFileToOpenSource
        public ApiFileToReturnModel AddFileToOpenSource(ApiFileToAddModel file)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/AddOrder
        public ApiOrderDetailsModel AddOrder(ApiOrderDetailsModel order)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/CloseOrder
        public ApiOrderDetailsModel CloseOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/user/AddReview
        public ApiReviewModel AddReview(ApiReviewModel review)
        {
            throw new Exception();
        }
    }
}
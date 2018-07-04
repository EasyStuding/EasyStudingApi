using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.Models;

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
        // /api/user/GetUsers
        public async Task<IQueryable<User>> GetUsers(string education, string country, string region, string city)
        {
            throw new Exception();
        }

        [HttpGet]
        // /api/user/GetUser
        public async Task<User> GetUser(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // /api/user/GetOrders
        public async Task<IQueryable<Order>> GetOrders()
        {
            throw new Exception();
        }

        [HttpGet]
        // /api/user/GetOrder
        public async Task<Order> GetOrder(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // /api/user/GetExecutors
        public async Task<IQueryable<User>> GetExecutors(string education, string country, string region, string city)
        {
            throw new Exception();
        }

        [HttpGet]
        // /api/user/GetOpenSourceAttachments
        public async Task<IQueryable<FileToReturnModel>> GetOpenSourceAttachments(long ownerOpenSourceId)
        {
            throw new Exception();
        }

        [HttpGet]
        // /api/user/OpenSourceDownloadFile
        public async Task<FileToReturnModel> OpenSourceDownloadFile(long fileId)
        {
            throw new Exception();
        }

        [HttpPost]
        // /api/user/ValidateEmail
        public async Task<bool> ValidateEmail(string validationCode)
        {
            throw new Exception();
        }

        [HttpPut]
        // /api/user/ChangePassword
        public async Task<bool> ChangePassword(string oldPassword, string newPassword)
        {
            throw new Exception();
        }

        [HttpPut]
        // /api/user/EditProfile
        public async Task<User> EditProfile(User user)
        {
            throw new Exception();
        }

        [HttpPost]
        // /api/user/AddPictureProfile
        public async Task<FileToReturnModel> AddPictureProfile(FileToAddModel file)
        {
            throw new Exception();
        }

        [HttpDelete]
        // /api/user/RemovePictureProfile
        public async Task<FileToReturnModel> RemovePictureProfile(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // /api/user/BuySubscription
        public async Task<User> BuySubscription(string name)
        {
            throw new Exception();
        }

        [HttpPost]
        // /api/user/AddFileToOpenSource
        public async Task<FileToReturnModel> AddFileToOpenSource(FileToAddModel file)
        {
            throw new Exception();
        }

        [HttpDelete]
        // /api/user/RemoveFileFromOpenSource
        public async Task<FileToReturnModel> RemoveFileFromOpenSource(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // /api/user/AddOrder
        public async Task<Order> AddOrder(Order order)
        {
            throw new Exception();
        }

        [HttpPost]
        // /api/user/StartExecuteOrder
        public async Task<Order> StartExecuteOrder(long id, long executorUserId)
        {
            throw new Exception();
        }

        [HttpPost]
        // /api/user/CloseOrder
        public async Task<Order> CloseOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // /api/user/AddReview
        public async Task<Review> AddReview(Review review)
        {
            throw new Exception();
        }
    }
}
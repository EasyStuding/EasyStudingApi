using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.Models;
using Microsoft.AspNetCore.Authorization;
using EasyStudingApi.Extensions;

namespace EasyStudingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/User/[action]")]
    [Authorize]
    public class UserController : Controller, IUserController
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        // /api/user/GetUsers
        public IQueryable<User> GetUsers(string education, string country, string region, string city)
        {
            return _service.GetUsers(education, country, region, city);
        }

        [HttpGet]
        // /api/user/GetUser
        public async Task<User> GetUser(long id)
        {
            return await _service.GetUser(id);
        }

        [HttpGet]
        // /api/user/GetOrders
        public async Task<IQueryable<Order>> GetOrders()
        {
            return await _service.GetOrders(User.GetUserId());
        }

        [HttpGet]
        // /api/user/GetOrder
        public async Task<Order> GetOrder(long id)
        {
            return await _service.GetOrder(id, User.GetUserId());
        }

        [HttpGet]
        // /api/user/GetExecutors
        public IQueryable<User> GetExecutors(string education, string country, string region, string city)
        {
            return _service.GetExecutors(education, country, region, city);
        }

        [HttpGet]
        // /api/user/GetOpenSourceAttachments
        public async Task<IQueryable<FileToReturnModel>> GetOpenSourceAttachments(long ownerOpenSourceId)
        {
            return await _service.GetOpenSourceAttachments(ownerOpenSourceId, User.GetUserId());
        }

        [HttpGet]
        // /api/user/OpenSourceDownloadFile
        public async Task<FileToReturnModel> OpenSourceDownloadFile(long fileId)
        {
            return await _service.OpenSourceDownloadFile(fileId, User.GetUserId());
        }

        [HttpPost]
        // /api/user/ValidateEmail
        public async Task<User> ValidateEmail(string validationCode)
        {
            return await _service.ValidateEmail(validationCode, User.GetUserId());
        }

        [HttpPut]
        // /api/user/ChangePassword
        public async Task<bool> ChangePassword(string oldPassword, string newPassword)
        {
            return await _service.ChangePassword(oldPassword, newPassword, User.GetUserId());
        }

        [HttpPut]
        // /api/user/EditProfile
        public async Task<User> EditProfile([FromBody]User user)
        {
            return await _service.EditProfile(user, User.GetUserId());
        }

        [HttpPost]
        // /api/user/AddPictureProfile
        public async Task<FileToReturnModel> AddPictureProfile([FromBody]FileToAddModel file)
        {
            return await _service.AddPictureProfile(file, User.GetUserId());
        }

        [HttpDelete]
        // /api/user/RemovePictureProfile
        public async Task<FileToReturnModel> RemovePictureProfile(long id)
        {
            return await _service.RemovePictureProfile(id, User.GetUserId());
        }

        [HttpPost]
        // /api/user/BuySubscription
        public async Task<User> BuySubscription(string name)
        {
            return await _service.BuySubscription(name, User.GetUserId());
        }

        [HttpPost]
        // /api/user/AddFileToOpenSource
        public async Task<FileToReturnModel> AddFileToOpenSource([FromBody]FileToAddModel file)
        {
            return await _service.AddFileToOpenSource(file, User.GetUserId());
        }

        [HttpDelete]
        // /api/user/RemoveFileFromOpenSource
        public async Task<FileToReturnModel> RemoveFileFromOpenSource(long id)
        {
            return await _service.RemoveFileFromOpenSource(id, User.GetUserId());
        }

        [HttpPost]
        // /api/user/AddOrder
        public async Task<Order> AddOrder([FromBody]Order order)
        {
            return await _service.AddOrder(order, User.GetUserId());
        }

        [HttpPost]
        // /api/user/StartExecuteOrder
        public async Task<Order> StartExecuteOrder(long id, long executorUserId)
        {
            return await _service.StartExecuteOrder(id, executorUserId, User.GetUserId());
        }

        [HttpPost]
        // /api/user/RefuseExecutor
        public async Task<Order> RefuseExecutor(long id)
        {
            return await _service.RefuseExecutor(id, User.GetUserId());
        }

        [HttpPost]
        // /api/user/CloseOrder
        public async Task<Order> CloseOrder(long id)
        {
            return await _service.CloseOrder(id, User.GetUserId());
        }

        [HttpPost]
        // /api/user/AddReview
        public async Task<Review> AddReview([FromBody]Review review)
        {
            return await _service.AddReview(review, User.GetUserId());
        }
    }
}
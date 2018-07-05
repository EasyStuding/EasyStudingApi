using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.Models;
using EasyStudingApi.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace EasyStudingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Executor/[action]")]
    [Authorize]
    public class ExecutorController : Controller, IExecutorController
    {
        private readonly IExecutorService Service;

        public ExecutorController(IExecutorService service)
        {
            Service = service;
        }

        [HttpGet]
        // /api/executor/GetOrders
        public async Task<IQueryable<Order>> GetOrders(string education, string country, string region, string city)
        {
            return await Service.GetOrders(education, country, region, city, User.GetUserId());
        }

        [HttpGet]
        // /api/executor/GetOrder
        public async Task<Order> GetOrder(long id)
        {
            return await Service.GetOrder(id, User.GetUserId());
        }

        [HttpGet]
        // /api/executor/GetTheRightsToPerformOrder
        public async Task<Order> GetTheRightsToPerformOrder(long id)
        {
            return await Service.GetTheRightsToPerformOrder(id, User.GetUserId());
        }

        [HttpPost]
        // /api/executor/CloseOrder
        public async Task<Order> CloseOrder(long id)
        {
            return await Service.CloseOrder(id, User.GetUserId());
        }

        [HttpPost]
        // /api/executor/AddSkill
        public async Task<Skill> AddSkill(long id)
        {
            return await Service.AddSkill(id, User.GetUserId());
        }

        [HttpDelete]
        // /api/executor/RemoveSkill
        public async Task<Skill> RemoveSkill(long id)
        {
            return await Service.RemoveSkill(id, User.GetUserId());
        }
    }
}
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
    [Route("api/Executor/[action]")]
    public class ExecutorController : Controller, IExecutorController
    {
        private readonly IExecutorService Service;

        public ExecutorController(IExecutorService service)
        {
            Service = service;
        }

        [HttpGet]
        // /api/executor/GetOrders
        public async Task<IQueryable<Order>> GetOrders(string education, string country, string city)
        {
            throw new Exception();
        }

        [HttpGet]
        // /api/executor/GetOrder
        public async Task<Order> GetOrder(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // /api/executor/GetTheRightsToPerformOrder
        public async Task<Order> GetTheRightsToPerformOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // /api/executor/CloseOrder
        public async Task<Order> CloseOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // /api/executor/AddSkill
        public async Task<Skill> AddSkill(long id)
        {
            throw new Exception();
        }

        [HttpDelete]
        // /api/executor/RemoveSkill
        public async Task<Skill> RemoveSkill(long id)
        {
            throw new Exception();
        }
    }
}
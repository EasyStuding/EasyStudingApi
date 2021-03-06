﻿using System.Linq;
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
        private readonly IExecutorService _service;

        public ExecutorController(IExecutorService service)
        {
            _service = service;
        }

        [HttpGet]
        // /api/executor/GetOrders
        public async Task<IQueryable<OrderToReturn>> GetOrders(string education, string country, string region, string city, string skills)
        {
            return await _service.GetOrders(education, country, region, city, skills, User.GetUserId());
        }

        [HttpGet]
        // /api/executor/GetOrder
        public async Task<OrderToReturn> GetOrder(long id)
        {
            return await _service.GetOrder(id, User.GetUserId());
        }

        [HttpGet]
        // /api/executor/GetTheRightsToPerformOrder
        public async Task<OrderToReturn> GetTheRightsToPerformOrder(long id)
        {
            return await _service.GetTheRightsToPerformOrder(id, User.GetUserId());
        }

        [HttpPost]
        // /api/executor/CloseOrder
        public async Task<OrderToReturn> CloseOrder(long id)
        {
            return await _service.CloseOrder(id, User.GetUserId());
        }

        [HttpPost]
        // /api/executor/AddSkill
        public async Task<Skill> AddSkill(long id)
        {
            return await _service.AddSkill(id, User.GetUserId());
        }

        [HttpDelete]
        // /api/executor/RemoveSkill
        public async Task<Skill> RemoveSkill(long id)
        {
            return await _service.RemoveSkill(id, User.GetUserId());
        }
    }
}
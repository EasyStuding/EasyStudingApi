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
    [Route("api/Executor/[action]")]
    public class ExecutorController : Controller, IExecutorController
    {
        private readonly IExecutorService Service;

        public ExecutorController(IExecutorService service)
        {
            Service = service;
        }

        [HttpGet]
        // * - host.
        // */api/executor/GetOrderDetailsModels
        public async Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels([FromBody]ApiEducationModel education, [FromBody]City city)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/executor/GetApiOrderDetailsModel
        public async Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/executor/GetTheRightsToPerformOrder
        public async Task<ApiOrderDetailsModel> GetTheRightsToPerformOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/executor/CloseOrder
        public async Task<ApiOrderDetailsModel> CloseOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/executor/AddSkill
        public async Task<Skill> AddSkill(long id)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/executor/RemoveSkill
        public async Task<Skill> RemoveSkill(long id)
        {
            throw new Exception();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Executor")]
    public class ExecutorController : Controller, IExecutorController
    {
        [HttpGet]
        // * - host.
        // */api/executor/GetOrderDetailsModels
        public IQueryable<ApiOrderDetailsModel> GetOrderDetailsModels(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/executor/GetApiOrderDetailsModel
        public ApiOrderDetailsModel GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/executor/GetTheRightsToPerformOrder
        public ApiOrderDetailsModel GetTheRightsToPerformOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/executor/StartExecuteOrder
        public ApiOrderDetailsModel StartExecuteOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/executor/CloseOrder
        public ApiOrderDetailsModel CloseOrder(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/executor/AddSkill
        public Skill AddSkill(long id)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/executor/RemoveSkill
        public Skill RemoveSkill(long id)
        {
            throw new Exception();
        }
    }
}
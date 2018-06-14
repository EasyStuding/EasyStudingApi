using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.DbContextModels;
using EasyStudingModels.ApiModels;

namespace EasyStudingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Session/[action]")]
    public class SessionController : Controller, ISessionController
    {
        private readonly ISessionService Service;

        public SessionController(ISessionService service)
        {
            Service = service;
        }

        [HttpPost]
        // * - host.
        // */api/session/StartRegistration
        public async Task<UserRegistration> StartRegistration([FromBody]ApiUserRegistrationModel apiUserRegistration)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/session/ValidateRegistration
        public async Task<UserRegistration> ValidateRegistration([FromBody]ValidationUser validationUser)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/session/CompleteRegistration
        public async Task<ApiUserInformationModel> CompleteRegistration([FromBody]ApiLoginModel apiLogin)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/session/Login
        public async Task<ApiUserInformationModel> Login([FromBody]ApiLoginModel apiLogin, bool isTelephone)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/session/LogOut
        public async Task<bool> LogOut()
        {
            throw new Exception();
        }
    }
}
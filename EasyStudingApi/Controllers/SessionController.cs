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
    //TODO: add attributes from body.
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
        public UserRegistration StartRegistration(ApiUserRegistrationModel apiUserRegistration)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/session/ValidateRegistration
        public UserRegistration ValidateRegistration(ValidationUser validationUser)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/session/CompleteRegistration
        public ApiUserInformationModel CompleteRegistration(ApiLoginModel apiLogin)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/session/Login
        public ApiUserInformationModel Login(ApiLoginModel apiLogin, bool isTelephone)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/session/LogOut
        public bool LogOut()
        {
            throw new Exception();
        }
    }
}
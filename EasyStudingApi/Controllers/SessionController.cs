using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingModels.DbContextModels;
using EasyStudingModels.ApiModels;

namespace EasyStudingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Session")]
    public class SessionController : Controller, ISessionController
    {
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
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
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace EasyStudingApi.Controllers
{
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/Session/[action]")]
    public class SessionController : Controller, ISessionController
    {
        private readonly ISessionService _service;

        public SessionController(ISessionService service)
        {
            _service = service;
        }

        [HttpPost]
        // * - host.
        // */api/session/StartRegistration
        public async Task<UserRegistration> StartRegistration([FromBody]ApiUserRegistrationModel apiUserRegistration)
        {
            return await _service.StartRegistration(apiUserRegistration);
        }

        [HttpPost]
        // */api/session/ValidateRegistration
        public async Task<UserRegistration> ValidateRegistration([FromBody]ValidationUser validationUser)
        {
            return await _service.ValidateRegistration(validationUser);
        }

        [HttpPost]
        // */api/session/CompleteRegistration
        public async Task<ApiLoginToken> CompleteRegistration([FromBody]ApiRegisrtationLoginModel apiRegistrationLogin)
        {
            return await _service.CompleteRegistration(apiRegistrationLogin);
        }

        [HttpPost]
        // */api/session/Login
        public async Task<ApiLoginToken> Login([FromBody]ApiLoginModel apiLogin, bool isTelephone)
        {
            return await _service.Login(apiLogin, isTelephone);
        }

        [Authorize]
        [HttpPost]
        // */api/session/UpdateToken
        public async Task<ApiLoginToken> UpdateToken()
        {
            return await _service.UpdateToken(long.Parse(User.Claims.ElementAt(0).Value));
        }

        [HttpPost]
        // */api/session/LogOut
        public async Task<bool> LogOut()
        {
            await HttpContext.SignOutAsync(JwtBearerDefaults.AuthenticationScheme);

            return true;
        }
    }
}
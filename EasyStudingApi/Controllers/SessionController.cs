using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace EasyStudingApi.Controllers
{
    [EnableCors("MyPolicy")]
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
        // /api/session/StartRegistration
        public async Task<User> StartRegistration([FromBody]RegistrationModel registrationModel)
        {
            return await _service.StartRegistration(registrationModel);
        }

        [HttpPost]
        // /api/session/ValidateRegistration
        public async Task<User> ValidateRegistration([FromBody]ValidateModel validateModel)
        {
            return await _service.ValidateRegistration(validateModel);
        }

        [HttpPost]
        // /api/session/CompleteRegistration
        public async Task<LoginToken> CompleteRegistration([FromBody]LoginModel loginModel)
        {
            return await _service.CompleteRegistration(loginModel);
        }

        [HttpPost]
        // /api/session/Login
        public async Task<LoginToken> Login([FromBody]LoginModel loginModel)
        {
            return await _service.Login(loginModel);
        }

        [Authorize]
        [HttpPost]
        // /api/session/UpdateToken
        public async Task<LoginToken> UpdateToken()
        {
            return await _service.UpdateToken(long.Parse(User.Claims.FirstOrDefault().Value));
        }

        [Authorize]
        [HttpPost]
        // /api/session/LogOut
        public async Task<bool> LogOut()
        {
            await HttpContext.SignOutAsync(JwtBearerDefaults.AuthenticationScheme);

            return true;
        }
    }
}
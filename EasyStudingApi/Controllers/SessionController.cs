using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.Models;
using Microsoft.AspNetCore.Authorization;
using EasyStudingApi.Extensions;

namespace EasyStudingApi.Controllers
{
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

        [HttpPost]
        // /api/session/GenerateValidationCode
        public bool GenerateValidationCode([FromBody]RegistrationModel registrationModel)
        {
            return _service.GetValidationCode(registrationModel);
        }

        [HttpPost]
        // /api/session/RestorePassword
        public async Task<LoginToken> RestorePassword([FromBody]RestorePasswordModel restorePasswordModel)
        {
            return await _service.RestorePassword(restorePasswordModel);
        }

        [Authorize]
        [HttpPost]
        // /api/session/UpdateToken
        public async Task<LoginToken> UpdateToken()
        {
            return await _service.UpdateToken(User.GetUserId());
        }

        [Authorize]
        [HttpPost]
        // /api/session/LogOut
        public bool LogOut()
        {
            return true;
        }

        //For dev.
        [HttpDelete]
        // /api/session/DeleteUserDev
        public async Task<bool> DeleteUserDev(string telNumber)
        {
            return await _service.DeleteUserDev(telNumber);
        }
    }
}
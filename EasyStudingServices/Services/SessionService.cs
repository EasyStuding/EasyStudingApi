using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingServices.Services
{
    public class SessionService: ISessionService
    {
        //TODO: initialize repositories;

        public async Task<UserRegistration> StartRegistration(ApiUserRegistrationModel apiUserRegistration)
        {
            throw new Exception();
        }

        public async Task<UserRegistration> ValidateRegistration(ValidationUser validationUser)
        {
            throw new Exception();
        }

        public async Task<ApiUserInformationModel> CompleteRegistration(ApiLoginModel apiLogin)
        {
            throw new Exception();
        }

        public async Task<ApiUserInformationModel> Login(ApiLoginModel apiLogin, bool isTelephone)
        {
            throw new Exception();
        }
    }
}

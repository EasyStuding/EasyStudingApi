using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyStudingServices.Services
{
    public class SessionService: ISessionService
    {
        //TODO: initialize repositories;

        public UserRegistration StartRegistration(ApiUserRegistrationModel apiUserRegistration)
        {
            throw new Exception();
        }

        public UserRegistration ValidateRegistration(ValidationUser validationUser)
        {
            throw new Exception();
        }

        public ApiUserInformationModel CompleteRegistration(ApiLoginModel apiLogin)
        {
            throw new Exception();
        }

        public ApiUserInformationModel Login(ApiLoginModel apiLogin, bool isTelephone)
        {
            throw new Exception();
        }
    }
}

using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData
{
    public class TestSessionRepository: ISessionRepository
    {
        public async Task<UserRegistration> StartRegistration(ApiUserRegistrationModel apiUserRegistration)
        {
            return new UserRegistration()
            {
                Id = 1,
                IsValidated = false,
                RegistrationDate = DateTime.Now,
                TelephoneNumber = "+375331111111"
            };
        }

        public async Task<UserRegistration> ValidateRegistration(ValidationUser validationUser)
        {
            if (validationUser.UserRegistrationId > 1)
            {
                return null;
            }

            return new UserRegistration()
            { 
                Id = 1,
                IsValidated = true,
                RegistrationDate = DateTime.Now,
                TelephoneNumber = "+375331111111"
            };
        }

        public async Task<ApiUserInformationModel> CompleteRegistration(ApiRegisrtationLoginModel apiRegistrationLogin)
        {
            if (apiRegistrationLogin.UserRegistrationId > 1)
            {
                return null;
            }

            return  new ApiUserInformationModel()
            {
                Id = 1,
                LoginName = "login1",
                Role = "user"
            };
        }

        public async Task<ApiUserInformationModel> GetApiUserInformationFromApiLoginAsync(ApiLoginModel apiLogin)
        {
            if (!apiLogin.Login.Equals("login1"))
            {
                return null;
            }

            return new ApiUserInformationModel()
            {
                Id = 1,
                LoginName = "login1",
                Role = "user"
            };
        }

        public async Task<ApiUserInformationModel> GetApiUserInformationByIdAsync(long userId)
        {
            if (userId > 1)
            {
                return null;
            }

            return new ApiUserInformationModel()
            {
                Id = 1,
                LoginName = "login1",
                Role = "user"
            };
        }
    }
}

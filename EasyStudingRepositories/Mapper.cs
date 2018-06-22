using EasyStudingModels;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyStudingRepositories
{
    public class Mapper
    {
        public UserRegistration ConvertApiUserRegistrationModelToUserRegistretion(ApiUserRegistrationModel apiUserRegistration)
        {
            return new UserRegistration
            {
                Id = 0,
                IsValidated = false,
                RegistrationDate = DateTime.Now,
                TelephoneNumber = apiUserRegistration.TelephoneNumber
            };
        }

        public ValidationUser ConvertUserRegistrationToValidationUser(UserRegistration userRegistration)
        {
            return new ValidationUser()
            {
                Id = 0,
                UserRegistrationId = userRegistration.Id,
                ValidationCode = "111111"
            };
        }

        public UserInformation ConvertApiRegistrationLoginToUserInformation(ApiRegisrtationLoginModel apiRegistrationLogin, long openSourceId,long  executorSubscriptionId)
        {
            return new UserInformation()
            {
                IsBanned = false,
                IsFreeTrial = true,
                IsGaranted = false,
                LoginName = apiRegistrationLogin.Login,
                Password = apiRegistrationLogin.Password,
                UserRegistrationId = apiRegistrationLogin.UserRegistrationId,
                RoleId = 1,
                OpenSourceId = openSourceId,
                SubscriptionExecutorId = executorSubscriptionId
            };
        }

        public ApiUserInformationModel ConvertUserInfoToApiUserInformationModel(UserInformation userInfo, string roleName)
        {
            return new ApiUserInformationModel()
            {
                Id = userInfo.Id,
                LoginName = userInfo.LoginName,
                Role = roleName
            };
        }

    }
}

using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Repositories
{
    public interface ISessionRepository
    {
        Task<UserRegistration> StartRegistration(ApiUserRegistrationModel apiUserRegistration);

        Task<UserRegistration> ValidateRegistration(ValidationUser validationUser);

        Task<ApiUserInformationModel> CompleteRegistration(ApiRegisrtationLoginModel apiRegistrationLogin);

        Task<ApiUserInformationModel> GetApiUserInformationFromApiLoginAsync(ApiLoginModel apiLogin);

        Task<ApiUserInformationModel> GetApiUserInformationByIdAsync(long userId);
    }
}

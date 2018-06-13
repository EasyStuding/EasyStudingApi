using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Services
{
    public interface ISessionService
    {
        UserRegistration StartRegistration(ApiUserRegistrationModel apiUserRegistration);

        UserRegistration ValidateRegistration(ValidationUser validationUser);

        ApiUserInformationModel CompleteRegistration(ApiLoginModel apiLogin);

        ApiUserInformationModel Login(ApiLoginModel apiLogin, bool isTelephone);
    }
}

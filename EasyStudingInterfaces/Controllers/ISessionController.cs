using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface ISessionController
    {
        UserRegistration StartRegistration(ApiUserRegistrationModel apiUserRegistration);

        UserRegistration ValidateRegistration(ValidationUser validationUser);

        ApiUserInformationModel CompleteRegistration(ApiLoginModel apiLogin);

        ApiUserInformationModel Login(ApiLoginModel apiLogin, bool isTelephone);

        bool LogOut();
    }
}

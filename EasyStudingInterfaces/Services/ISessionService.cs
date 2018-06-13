using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Services
{
    public interface ISessionService
    {
        UserRegistration StartRegistration(ApiUserRegistration apiUserRegistration);

        UserRegistration ValidateRegistration(ValidationUser validationUser);

        ApiUserInformation CompleteRegistration(ApiLogin apiLogin);

        ApiUserInformation Login(ApiLogin apiLogin, bool isTelephone);
    }
}

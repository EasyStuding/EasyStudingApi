using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface ISessionController
    {
        UserRegistration StartRegistration(ApiUserRegistration apiUserRegistration);

        UserRegistration ValidateRegistration(ValidationUser validationUser);

        ApiUserInformation CompleteRegistration(ApiLogin apiLogin);

        ApiUserInformation Login(ApiLogin apiLogin, bool isTelephone);

        bool LogOut();
    }
}

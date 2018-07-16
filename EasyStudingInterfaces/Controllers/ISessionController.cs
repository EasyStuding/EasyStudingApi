using EasyStudingModels.Models;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface ISessionController
    {
        Task<User> StartRegistration(RegistrationModel registrationModel);

        Task<User> ValidateRegistration(ValidateModel validateModel);

        Task<LoginToken> CompleteRegistration(LoginModel loginModel);

        Task<LoginToken> Login(LoginModel loginModel);

        bool GenerateValidationCode(RegistrationModel registrationModel);

        Task<LoginToken> RestorePassword(RestorePasswordModel restorePasswordModel);

        Task<LoginToken> UpdateToken();

        bool LogOut();

        //For dev.
        Task<bool> DeleteUserDev(string telNumber);
    }
}

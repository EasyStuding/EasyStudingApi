using EasyStudingModels.Models;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Services
{
    public interface ISessionService
    {
        Task<User> StartRegistration(RegistrationModel registrationModel);

        Task<User> ValidateRegistration(ValidateModel validateModel);

        Task<LoginToken> CompleteRegistration(LoginModel loginModel);

        Task<LoginToken> Login(LoginModel loginModel);

        bool GetValidationCode(RegistrationModel registrationModel);

        Task<LoginToken> RestorePassword(RestorePasswordModel restorePasswordModel);

        Task<LoginToken> UpdateToken(long currentUserId);

        //For dev.
        Task<bool> DeleteUserDev(string telNumber);
    }
}

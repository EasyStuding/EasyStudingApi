using EasyStudingModels.Models;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Repositories
{
    public interface ISessionRepository
    {
        Task<User> StartRegistration(RegistrationModel registrationModel);

        Task<User> ValidateRegistration(ValidateModel validateModel);

        Task<User> CompleteRegistration(LoginModel loginModel);

        Task<User> Login(LoginModel loginModel);

        Task<User> GetUserById(long currentUserId);

        string GetValidationCode(string key);

        Task<User> RestorePassword(RestorePasswordModel restorePasswordModel);

        //For dev.
        Task<bool> DeleteUserDev(string telNumber);
    }
}

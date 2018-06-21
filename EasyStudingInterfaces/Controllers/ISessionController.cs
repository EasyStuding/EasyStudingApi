using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface ISessionController
    {
        Task<UserRegistration> StartRegistration(ApiUserRegistrationModel apiUserRegistration);

        Task<UserRegistration> ValidateRegistration(ValidationUser validationUser);

        Task<ApiLoginToken> CompleteRegistration(ApiRegisrtationLoginModel apiRegistrationLogin);

        Task<ApiLoginToken> Login(ApiLoginModel apiLogin, bool isTelephone);

        Task<ApiLoginToken> UpdateToken();

        Task<bool> LogOut();
    }
}

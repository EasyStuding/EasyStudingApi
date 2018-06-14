using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface ISessionController
    {
        Task<UserRegistration> StartRegistration(ApiUserRegistrationModel apiUserRegistration);

        Task<UserRegistration> ValidateRegistration(ValidationUser validationUser);

        Task<ApiUserInformationModel> CompleteRegistration(ApiLoginModel apiLogin);

        Task<ApiUserInformationModel> Login(ApiLoginModel apiLogin, bool isTelephone);

        Task<bool> LogOut();
    }
}

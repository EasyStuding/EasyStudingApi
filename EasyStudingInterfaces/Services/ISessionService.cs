using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Services
{
    public interface ISessionService
    {
        Task<UserRegistration> StartRegistration(ApiUserRegistrationModel apiUserRegistration);

        Task<UserRegistration> ValidateRegistration(ValidationUser validationUser);

        Task<ApiUserInformationModel> CompleteRegistration(ApiLoginModel apiLogin);

        Task<ApiUserInformationModel> Login(ApiLoginModel apiLogin, bool isTelephone);
    }
}

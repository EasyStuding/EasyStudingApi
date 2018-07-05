using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData
{
    public class TestSessionRepository : ISessionRepository
    {
        public async Task<User> StartRegistration(RegistrationModel registrationModel)
        {
            return new User()
            {
                Id = 1,
                TelephoneNumber = "+375331111111",
                RegistrationDate = DateTime.Now,
                Role = "user",
                TelephoneNumberIsValidated = false
            };
        }

        public async Task<User> ValidateRegistration(ValidateModel validateModel)
        {
            return new User()
            {
                Id = 1,
                TelephoneNumber = "+375331111111",
                RegistrationDate = DateTime.Now,
                Role = "user",
                TelephoneNumberIsValidated = true
            };
        }

        public async Task<User> CompleteRegistration(LoginModel loginModel)
        {
            return new User()
            {
                Id = 1,
                TelephoneNumber = "+375331111111",
                RegistrationDate = DateTime.Now,
                Role = "user",
                TelephoneNumberIsValidated = true,
                FullName = "Full name of user"
            };
        }

        public async Task<User> GetUserById(long currentUserId)
        {
            return new User()
            {
                Id = 1,
                TelephoneNumber = "+375331111111",
                RegistrationDate = DateTime.Now,
                Role = "user",
                TelephoneNumberIsValidated = true,
                FullName = "Full name of user"
            };
        }

        public async Task<User> Login(LoginModel loginModel)
        {
            return new User()
            {
                Id = 1,
                TelephoneNumber = "+375331111111",
                RegistrationDate = DateTime.Now,
                Role = "user",
                TelephoneNumberIsValidated = true,
                FullName = "Full name of user"
            };
        }

        // Get from MD5 hash 6 characters.
        public string GetValidationCode(string key)
        {
            return "111111";
        }

        public async Task<User> RestorePassword(RestorePasswordModel restorePasswordModel)
        {
            return new User()
            {
                Id = 1,
                TelephoneNumber = "+375331111111",
                RegistrationDate = DateTime.Now,
                Role = "user",
                TelephoneNumberIsValidated = true,
                FullName = "Full name of user"
            };
        }

        // For dev.
        public async Task<bool> DeleteUserDev(string telNumber)
        {
            return true;
        }
    }
}

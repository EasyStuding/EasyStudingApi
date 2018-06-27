using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if (validateModel.UserId > 1)
            {
                return null;
            }

            if (!validateModel.ValidationCode.Equals("111111"))
            {
                return null;
            }

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
            if (!loginModel.TelephoneNumber.Equals("+375331111111"))
            {
                return null;
            }

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
            if (currentUserId > 1)
            {
                return null;
            }

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
            if (!loginModel.TelephoneNumber.Equals("+375331111111"))
            {
                return null;
            }

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
    }
}

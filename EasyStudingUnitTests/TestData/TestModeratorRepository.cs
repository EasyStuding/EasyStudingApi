using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData
{
    public class TestModeratorRepository: IModeratorRepository
    {
        public async Task<User> GrantModeratorRights(long userId)
        {
            return new User()
            {
                Id = 1,
                TelephoneNumber = "+375331111111",
                RegistrationDate = DateTime.Now,
                Role = "moderator",
                TelephoneNumberIsValidated = false,
                BanExpiresDate = DateTime.Now.AddMonths(3)
            };
        }

        public async Task<User> BanUser(long id)
        {
            return new User()
            {
                Id = 1,
                TelephoneNumber = "+375331111111",
                RegistrationDate = DateTime.Now,
                Role = "user",
                TelephoneNumberIsValidated = false,
                BanExpiresDate = DateTime.Now.AddMonths(3)
            };
        }

        public async Task<User> RemoveBanOfUser(long id)
        {
            return new User()
            {
                Id = 1,
                TelephoneNumber = "+375331111111",
                RegistrationDate = DateTime.Now,
                Role = "user",
                TelephoneNumberIsValidated = false,
                BanExpiresDate = DateTime.Now
            };
        }

        public async Task<Order> CloseOrder(long id)
        {
            return new Order()
            {
                Id = 1,
                CustomerId = 1,
                ExecutorId = 2,
                Description = "description",
                Title = "title",
                IsClosedByCustomer = false,
                IsClosedByExecutor = false,
                IsCompleted = true
            };
        }

        public IQueryable<Order> GetOrders(string education, string country, string region, string city)
        {
            return new[]
            {
                new Order(),
                new Order(),
                new Order(),
                new Order(),
                new Order()
            }.AsQueryable();
        }

        public async Task<Order> GetOrder(long id)
        {
            return new Order()
            {
                Id = 1,
                CustomerId = 1,
                ExecutorId = 2,
                Description = "description",
                Title = "title"
            };
        }
    }
}

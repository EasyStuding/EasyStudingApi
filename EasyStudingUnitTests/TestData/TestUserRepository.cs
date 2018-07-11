using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData
{
    public class TestUserRepository: IUserRepository
    {
        public IQueryable<Skill> GetSkills()
        {
            return new[]
            {
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill()
            }.AsQueryable();
        }

        public async Task<Skill> GetSkill(long id)
        {
            return new Skill
            {
                Id = 1,
                Name = "Экономика"
            };
        }

        public IQueryable<User> GetUsers(string education, string country, string region, string city)
        {
            return new[]
            {
                new User(),
                new User(),
                new User(),
                new User(),
                new User()
            }.AsQueryable();
        }

        public async Task<User> GetUser(long id)
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

        public async Task<IQueryable<OrderToReturn>> GetOrders(long currentUserId)
        {
            return new[]
            {
                new OrderToReturn(),
                new OrderToReturn(),
                new OrderToReturn(),
                new OrderToReturn(),
                new OrderToReturn()
            }.AsQueryable();
        }

        public async Task<OrderToReturn> GetOrder(long id, long currentUserId)
        {
            return new OrderToReturn()
            {
                Id = 1
            };
        }

        public IQueryable<User> GetExecutors(string education, string country, string region, string city)
        {
            return new[]
{
                new User(),
                new User(),
                new User(),
                new User(),
                new User()
            }.AsQueryable();
        }

        public async Task<IQueryable<FileToReturnModel>> GetOpenSourceAttachments(long ownerOpenSourceId, long currentUserId)
        {
            return new[]
            {
                new FileToReturnModel(),
                new FileToReturnModel(),
                new FileToReturnModel(),
                new FileToReturnModel(),
                new FileToReturnModel()
            }.AsQueryable();
        }

        public async Task<FileToReturnModel> OpenSourceDownloadFile(long fileId, long currentUserId)
        {
            return new FileToReturnModel()
            {
                Id = 1
            };
        }

        public async Task<bool> ChangePassword(string oldPassword, string newPassword, long currentUserId)
        {
            return true;
        }

        public async Task<User> EditProfile(User user, long currentUserId)
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

        public async Task<User> ValidateEmail(ValidateModel validateModel, long currentUserId)
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

        public string GetValidationCode(string key)
        {
            return "111111";
        }

        public async Task<User> AddPictureProfile(FileToAddModel file, string currentUrl, long currentUserId)
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

        public async Task<User> RemovePictureProfile(long currentUserId)
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

        public async Task<User> BuySubscription(string name, long currentUserId)
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

        public async Task<FileToReturnModel> AddFileToOpenSource(FileToAddModel file, string currentUrl, long currentUserId)
        {
            return new FileToReturnModel()
            {
                Id = 1
            };
        }

        public async Task<FileToReturnModel> RemoveFileFromOpenSource(long id, long currentUserId)
        {
            return new FileToReturnModel()
            {
                Id = 1
            };
        }

        public async Task<OrderToReturn> AddOrder(OrderToAdd order, string currentUrl, long currentUserId)
        {
            return new OrderToReturn()
            {
                Id = 1
            };
        }

        public async Task<OrderToReturn> StartExecuteOrder(long id, long executorUserId, long currentUserId)
        {
            return new OrderToReturn()
            {
                Id = 1
            };
        }

        public async Task<OrderToReturn> RefuseExecutor(long id, long currentUserId)
        {
            return new OrderToReturn()
            {
                Id = 1
            };
        }

        public async Task<OrderToReturn> CloseOrder(long id, long currentUserId)
        {
            return new OrderToReturn()
            {
                Id = 1
            };
        }

        public async Task<Review> AddReview(Review review, long currentUserId)
        {
            return new Review()
            {
                Id = 1
            };
        }
    }
}

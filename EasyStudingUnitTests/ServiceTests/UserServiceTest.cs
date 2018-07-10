using EasyStudingServices.Services;
using EasyStudingModels.Models;
using EasyStudingUnitTests.TestData;
using System;
using Xunit;
using System.Linq;
using EasyStudingModels;

namespace EasyStudingUnitTests.ServiceTests
{
    public class UserServiceTest
    {
        [Fact(DisplayName = "UserService.GetUsers() should return 5 objects.")]
        public void UserService_GetUsers_should_return_5_objects()
        {
            var service = new UserService(new TestUserRepository());

            var result = service.GetUsers(null, null, null, null);

            Assert.Equal(5, result.Count());
        }

        [Fact(DisplayName = "UserService.GetUser(1) should return object with id 1.")]
        public async void UserService_GetUser_1_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.GetUser(1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.GetOrders(1) should return 5 objects.")]
        public async void UserService_GetOrders_1_should_return_5_objects()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.GetOrders(1);

            Assert.Equal(5, result.Count());
        }

        [Fact(DisplayName = "UserService.GetOrder(1, 1) should return object with id 1.")]
        public async void UserService_GetOrder_1_1_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.GetOrder(1, 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.GetExecutors() should return 5 objects.")]
        public void UserService_GetExecutors_should_return_5_objects()
        {
            var service = new UserService(new TestUserRepository());

            var result = service.GetExecutors(null, null, null, null);

            Assert.Equal(5, result.Count());
        }

        [Fact(DisplayName = "UserService.GetOpenSourceAttachments(1, 1) should return 5 objects.")]
        public async void UserService_GetOpenSourceAttachments_1_1_should_return_5_objects()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.GetOpenSourceAttachments(1, 1);

            Assert.Equal(5, result.Count());
        }

        [Fact(DisplayName = "UserService.OpenSourceDownloadFile(1, 1) should return object with id 1.")]
        public async void UserService_OpenSourceDownloadFile_1_1_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.OpenSourceDownloadFile(1, 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.ChangePassword(valid, valid, 1) should return true.")]
        public async void UserService_ChangePassword_valid_should_return_true()
        {
            var service = new UserService(new TestUserRepository());

            Assert.True(await service.ChangePassword("HelloWorld123!", "Hello123!", 1));
        }

        [Fact(DisplayName = "UserService.ChangePassword(valid, invalid, 1) should return ArgumentException.")]
        public async void UserService_ChangePassword_invalid_should_return_ArgumentException()
        {
            var service = new UserService(new TestUserRepository());
            
            var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.ChangePassword("HelloWorld123!", "helloworld", 1));

            Assert.Equal(typeof(ArgumentException), result.GetType());
        }

        [Fact(DisplayName = "UserService.EditProfile(valid, 1) should return object with id 1.")]
        public async void UserService_EditProfile_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.EditProfile(new User
            {
                Id = 1,
                BanExpiresDate = DateTime.Now,
                City = null,
                Country = null,
                Description = null,
                Education = null,
                Email = null,
                EmailIsValidated = false,
                SubscriptionExecutorExpiresDate = DateTime.Now,
                TelephoneNumber = "+375291111111",
                FullName = null,
                PictureLink = null,
                Raiting = 5,
                Region = null,
                RegistrationDate = DateTime.Now,
                Role = "user",
                SubscriptionOpenSourceExpiresDate = DateTime.Now,
                TelephoneNumberIsValidated = true,
                UserIsGaranted = false
            }, 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.EditProfile(invalid, 1) should return ArgumentException.")]
        public async void UserService_EditProfile_invalid_should_return_ArgumentException()
        {
            var service = new UserService(new TestUserRepository());

            var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.EditProfile(new User
            {
                TelephoneNumber = null
            }, 1));

            Assert.Equal(typeof(ArgumentException), result.GetType());
        }

        [Fact(DisplayName = "UserService.ValidateEmail(valid, 1) should return object with id 1.")]
        public async void UserService_ValidateEmail_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.ValidateEmail(new ValidateModel
            {
                UserId = 1,
                ValidationCode = "111111"
            }, 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.ValidateEmail(invalid, 1) should return ArgumentException.")]
        public async void UserService_ValidateEmail_invalid_should_return_ArgumentException()
        {
            var service = new UserService(new TestUserRepository());

            var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.ValidateEmail(new ValidateModel
            {
                UserId = 1,
                ValidationCode = null
            }, 1));

            Assert.Equal(typeof(ArgumentException), result.GetType());
        }

        [Fact(DisplayName = "UserService.GetValidationCode(1) should return true.")]
        public async void UserService_GetValidationCode_1_should_return_true()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.GetValidationCode(1);

            Assert.True(result);
        }

        [Fact(DisplayName = "UserService.AddPictureProfile(valid) should return object with id 1.")]
        public async void UserService_AddPictureProfile_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.AddPictureProfile(new FileToAddModel
            {
                ContainerId = 1,
                ContainerName = Defines.AttachmentContainerName.USER,
                Data = "asdfasdfasfdsafdsa",
                Name = "asdf.jpg",
                Type = "image/jpeg"
            }, "url", 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.AddPictureProfile(invalid) should return ArgumentException.")]
        public async void UserService_AddPictureProfile_invalid_should_return_ArgumentException()
        {
            var service = new UserService(new TestUserRepository());

            var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.AddPictureProfile(new FileToAddModel(), "url", 1));

            Assert.Equal(typeof(ArgumentException), result.GetType());
        }

        [Fact(DisplayName = "UserService.RemovePictureProfile(1) should return object with id 1.")]
        public async void UserService_RemovePictureProfile_1_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.RemovePictureProfile(1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.BuySubscription(valid, 1) should return object with id 1.")]
        public async void UserService_BuySubscription_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.BuySubscription(Defines.Subscription.EXECUTOR, 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.BuySubscription(invalid, 1) should return ArgumentException.")]
        public async void UserService_BuySubscription_invalid_should_return_ArgumentException()
        {
            var service = new UserService(new TestUserRepository());

            var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.BuySubscription("example", 1));

            Assert.Equal(typeof(ArgumentException), result.GetType());
        }

        [Fact(DisplayName = "UserService.AddFileToOpenSource(valid) should return object with id 1.")]
        public async void UserService_AddFileToOpenSource_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.AddFileToOpenSource(new FileToAddModel
            {
                ContainerId = 1,
                ContainerName = Defines.AttachmentContainerName.USER,
                Data = "asdfasdfasfdsafdsa",
                Name = "asdf.jpg",
                Type = "image/jpeg"
            }, "url", 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.AddFileToOpenSource(invalid) should return ArgumentException.")]
        public async void UserService_AddFileToOpenSource_invalid_should_return_ArgumentException()
        {
            var service = new UserService(new TestUserRepository());

            var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.AddFileToOpenSource(new FileToAddModel(), "url", 1));

            Assert.Equal(typeof(ArgumentException), result.GetType());
        }

        [Fact(DisplayName = "UserService.RemoveFileFromOpenSource(valid) should return object with id 1.")]
        public async void UserService_RemoveFileFromOpenSource_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.RemoveFileFromOpenSource(1, 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.AddOrder(valid) should return object with id 1.")]
        public async void UserService_AddOrder_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.AddOrder(new OrderToAdd
            {
                Id = 1,
                Attachments = null,
                CustomerId = 1,
                ExecutorId = null,
                Description = "adsf",
                Title = "asdf"
            }, "url", 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.AddOrder(invalid) should return ArgumentException.")]
        public async void UserService_AddOrder_invalid_should_return_ArgumentException()
        {
            var service = new UserService(new TestUserRepository());

            var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.AddOrder(new OrderToAdd() { CustomerId = -1 }, "url", 1));

            Assert.Equal(typeof(ArgumentException), result.GetType());
        }

        [Fact(DisplayName = "UserService.StartExecuteOrder(valid) should return object with id 1.")]
        public async void UserService_StartExecuteOrder_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.StartExecuteOrder(1, 2, 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.RefuseExecutor(valid) should return object with id 1.")]
        public async void UserService_RefuseExecutor_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.RefuseExecutor(1, 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.CloseOrder(valid) should return object with id 1.")]
        public async void UserService_CloseOrder_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.CloseOrder(1, 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.AddReview(valid) should return object with id 1.")]
        public async void UserService_AddReview_valid_should_return_object_1()
        {
            var service = new UserService(new TestUserRepository());

            var result = await service.AddReview(new Review()
            {
                ReviewOwnerId = 1,
                ReviewRecipientId = 2,
                Description = "asd",
                Title = "asdfasfd",
                Raiting = 5
            }, 1);

            Assert.Equal(1, result.Id);
        }

        [Fact(DisplayName = "UserService.AddReview(invalid) should return ArgumentException.")]
        public async void UserService_AddReview_invalid_should_return_ArgumentException()
        {
            var service = new UserService(new TestUserRepository());

            var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.AddReview(new Review()
            {
                ReviewOwnerId = -1,
                ReviewRecipientId = -2,
                Description = "",
                Title = "",
                Raiting = -1
            }, 1));

            Assert.Equal(typeof(ArgumentException), result.GetType());
        }
    }
}

using EasyStudingRepositories.DbContext;
using EasyStudingServices.Services;
using EasyStudingModels.DbContextModels;
using EasyStudingModels.ApiModels;
using EasyStudingUnitTests.TestData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;

namespace EasyStudingUnitTests.ServiceTests
{
    public class SessionServiceTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "SessionService.StartRegistration(valid_model) should return object with id 1.")]
        public async void SessionService_StartRegistration_valid_model_should_return_object_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await service.StartRegistration(new ApiUserRegistrationModel() { TelephoneNumber = "+375339999999" });

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "SessionService.StartRegistration(invalid_model) should return FormatException.")]
        public async void SessionService_StartRegistration_invalid_model_should_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<FormatException>(async () => await service.StartRegistration(new ApiUserRegistrationModel() { TelephoneNumber = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.ValidateRegistration(valid_model) should return object with id 1.")]
        public async void SessionService_ValidateRegistration_valid_model_should_return_object_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await service.ValidateRegistration(new ValidationUser() { Id = 1, UserRegistrationId = 1, ValidationCode = "111111" });

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "SessionService.ValidateRegistration(invalid_model) should return FormatException.")]
        public async void SessionService_ValidateRegistration_invalid_model_should_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<FormatException>(async () => await service.ValidateRegistration(new ValidationUser() { Id = 1, UserRegistrationId = 1, ValidationCode = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.ValidateRegistration(index_out_of_range_model) should return ArgumentNullException.")]
        public async void SessionService_ValidateRegistration_index_out_of_range_model_should_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<ArgumentNullException>(async () => await service.ValidateRegistration(new ValidationUser() { Id = 6, UserRegistrationId = 6, ValidationCode = "111111" }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.CompleteRegistration(valid_model) should return object.")]
        public async void SessionService_CompleteRegistration_valid_model_should_return_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await service.CompleteRegistration(new ApiRegisrtationLoginModel() { UserRegistrationId = 1, Login = "login1", Password = "password1" });

                Assert.Equal(typeof(ApiLoginToken), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.CompleteRegistration(invalid_model) should return FormatException.")]
        public async void SessionService_CompleteRegistration_invalid_model_should_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<FormatException>(async () => await service.CompleteRegistration(new ApiRegisrtationLoginModel() { UserRegistrationId = 1, Login = "", Password = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.CompleteRegistration(index_out_of_range_model) should return ArgumentNullException.")]
        public async void SessionService_CompleteRegistration_index_out_of_range_model_should_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<ArgumentNullException>(async () => await service.CompleteRegistration(new ApiRegisrtationLoginModel() { UserRegistrationId = 6, Login = "asdfsadf", Password = "asdfsadf" }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.Login(valid_model) should return object.")]
        public async void SessionService_Login_valid_model_should_return_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await service.Login(new ApiLoginModel() { Login = "login1", Password = "password1" }, false);

                Assert.Equal(typeof(ApiLoginToken), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.Login(invalid_model) should return FormatException.")]
        public async void SessionService_Login_invalid_model_should_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<FormatException>(async () => await service.Login(new ApiLoginModel() { Login = "", Password = "" }, false));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.Login(not_contain) should return ArgumentNullException.")]
        public async void SessionService_Login_not_contain_should_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<ArgumentNullException>(async () => await service.Login(new ApiLoginModel() { Login = "asdfsadf", Password = "sadfsadf" }, false));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }
    }
}

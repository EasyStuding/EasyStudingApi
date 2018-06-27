using EasyStudingRepositories.DbContext;
using EasyStudingServices.Services;
using EasyStudingModels.Models;
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

                var result = await service.StartRegistration(new RegistrationModel() { TelephoneNumber = "+375331111111" });

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "SessionService.StartRegistration(invalid_model) should return ArgumentException.")]
        public async void SessionService_StartRegistration_invalid_model_should_ArgumentException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.StartRegistration(new RegistrationModel() {  TelephoneNumber = "" }));

                Assert.Equal(typeof(ArgumentException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.ValidateRegistration(valid_model) should return object with id 1.")]
        public async void SessionService_ValidateRegistration_valid_model_should_return_object_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await service.ValidateRegistration(new ValidateModel() { UserId = 1, ValidationCode = "111111" });

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "SessionService.ValidateRegistration(invalid_model) should return ArgumentException.")]
        public async void SessionService_ValidateRegistration_invalid_model_should_ArgumentException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.ValidateRegistration(new ValidateModel() { UserId = 1, ValidationCode = "" }));

                Assert.Equal(typeof(ArgumentException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.ValidateRegistration(index_out_of_range_model) should return ArgumentNullException.")]
        public async void SessionService_ValidateRegistration_index_out_of_range_model_should_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<ArgumentNullException>(async () => await service.ValidateRegistration(new ValidateModel() { UserId = 6, ValidationCode = "111111" }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.CompleteRegistration(valid_model) should return object.")]
        public async void SessionService_CompleteRegistration_valid_model_should_return_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await service.CompleteRegistration(new LoginModel() { TelephoneNumber = "+375331111111", Password = "Password123!" });

                Assert.Equal(typeof(LoginToken), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.CompleteRegistration(invalid_model) should return ArgumentException.")]
        public async void SessionService_CompleteRegistration_invalid_model_should_ArgumentException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.CompleteRegistration(new LoginModel() { TelephoneNumber = "", Password = "password" }));

                Assert.Equal(typeof(ArgumentException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.CompleteRegistration(index_out_of_range_model) should return ArgumentNullException.")]
        public async void SessionService_CompleteRegistration_index_out_of_range_model_should_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<ArgumentNullException>(async () => await service.CompleteRegistration(new LoginModel() { TelephoneNumber = "+375331231231", Password = "Password123!" }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.Login(valid_model) should return object.")]
        public async void SessionService_Login_valid_model_should_return_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await service.Login(new LoginModel() { TelephoneNumber = "+375331111111", Password = "Password123!" });

                Assert.Equal(typeof(LoginToken), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.Login(invalid_model) should return ArgumentException.")]
        public async void SessionService_Login_invalid_model_should_ArgumentException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<ArgumentException>(async () => await service.Login(new LoginModel() { TelephoneNumber = "", Password = "password" }));

                Assert.Equal(typeof(ArgumentException), result.GetType());
            }
        }

        [Fact(DisplayName = "SessionService.Login(not_contain) should return ArgumentNullException.")]
        public async void SessionService_Login_not_contain_should_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new SessionService(new TestSessionRepository());

                var result = await Assert.ThrowsAsync<ArgumentNullException>(async () => await service.Login(new LoginModel() { TelephoneNumber = "+375331231231", Password = "Password123!" }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }
    }
}

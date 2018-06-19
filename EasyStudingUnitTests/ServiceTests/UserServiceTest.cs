using EasyStudingRepositories.DbContext;
using EasyStudingUnitTests.TestData.Repositories;
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
    public class UserServiceTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "UserService.GetApiUserDescriptionModels(null, null) should return 5 objects.")]
        public async void UserService_GetApiUserDescriptionModels_null_null_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );
                var result = await service.GetApiUserDescriptionModels(null, null);

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "UserService.GetApiUserDescriptionModels(invalid, null) should return FormatException.")]
        public void UserService_GetApiUserDescriptionModels_invalid_null_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<FormatException>(
                    async () => await service
                                .GetApiUserDescriptionModels(
                        new ApiEducationModel() { Id = 1, City = null, Country = null, EducationName = null, Educationtype = null },
                        null));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.GetApiUserDescriptionModels(null, out index) should return IndexOutOfRangeException.")]
        public void UserService_GetApiUserDescriptionModels_null_outIndex_should_return_IndexOutOfRangeException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<IndexOutOfRangeException>(
                    async () => await service
                                .GetApiUserDescriptionModels(
                        null,
                        new City() { Id = 7, CountryId = 1, Name = "city", Region = null }));

                Assert.Equal(typeof(IndexOutOfRangeException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.GetApiUserDescriptionModel(1) should return first object.")]
        public async void UserService_GetApiUserDescriptionModel_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.GetApiUserDescriptionModel(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "UserService.GetApiUserDescriptionModel(6) should return ArgumentNullException.")]
        public void UserService_GetApiUserDescriptionModel_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<ArgumentNullException>(
                    async () => await service
                                .GetApiUserDescriptionModel(6));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.GetApiOrderDetailsModels(1) should return 1 object.")]
        public async void UserService_GetApiOrderDetailsModels_1_should_return_1_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );
                var result = await service.GetApiOrderDetailsModels(1);

                Assert.Equal(1, result.Count());
            }
        }

        [Fact(DisplayName = "UserService.GetApiUserDescriptionModels(7) should return UnauthorizedAccessException.")]
        public void UserService_GetApiUserDescriptionModels_7_should_return_UnauthorizedAccessException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<UnauthorizedAccessException>(
                    async () => await service
                                .GetApiOrderDetailsModels(7));

                Assert.Equal(typeof(UnauthorizedAccessException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.GetApiOrderDetailsModel(1, 1) should return first object.")]
        public async void UserService_GetApiOrderDetailsModell_1_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.GetApiOrderDetailsModel(1, 1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "UserService.GetApiOrderDetailsModel(6, 1) should return ArgumentNullException.")]
        public void UserService_GetApiOrderDetailsModel_6_1_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<ArgumentNullException>(
                    async () => await service
                                .GetApiOrderDetailsModel(6, 1));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.GetApiOrderDetailsModel(1, 4) should return UnauthorizedAccessException.")]
        public void UserService_GetApiOrderDetailsModel_1_4_should_return_UnauthorizedAccessException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<UnauthorizedAccessException>(
                    async () => await service
                                .GetApiOrderDetailsModel(1, 4));

                Assert.Equal(typeof(UnauthorizedAccessException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.GetSubscriptionExecutors(null, null) should return 5 objects.")]
        public async void UserService_GetSubscriptionExecutors_null_null_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );
                var result = await service.GetSubscriptionExecutors(null, null);

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "UserService.GetSubscriptionExecutors(invalid, null) should return FormatException.")]
        public void UserService_GetSubscriptionExecutors_invalid_null_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<FormatException>(
                    async () => await service
                                .GetSubscriptionExecutors(
                        new ApiEducationModel() { Id = 1, City = null, Country = null, EducationName = null, Educationtype = null },
                        null));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.GetSubscriptionExecutors(null, out index) should return IndexOutOfRangeException.")]
        public void UserService_GetSubscriptionExecutors_null_outIndex_should_return_IndexOutOfRangeException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<IndexOutOfRangeException>(
                    async () => await service
                                .GetSubscriptionExecutors(
                        null,
                        new City() { Id = 7, CountryId = 1, Name = "city", Region = null }));

                Assert.Equal(typeof(IndexOutOfRangeException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.ChangePassword('password1', 'Password11', 1) should return true.")]
        public async void UserService_ChangePassword_password1_Password11_1_should_return_true()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.ChangePassword("password1", "Password11", 1);

                Assert.True(result);
            }
        }

        [Fact(DisplayName = "UserService.ChangePassword(valid, invalid, 1) should return FormatException.")]
        public void UserService_ChangePassword_valid_invalid_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<FormatException>(
                    async () => await service
                                .ChangePassword("password1", "asdfsadfasdfsadfsadfsa", 1));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.ChangePassword(valid, valid, 6) should return IndexOutOfRangeException.")]
        public void UserService_ChangePassword_valid_valid_6_should_return_IndexOutOfRangeException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<IndexOutOfRangeException>(
                    async () => await service
                                .ChangePassword("password6", "Password66", 6));

                Assert.Equal(typeof(IndexOutOfRangeException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.EditProfile(valid, 1) should return object id 1.")]
        public async void UserService_EditProfile_valid_1_should_return_object_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.EditProfile(new ApiUserDescriptionModel()
                {
                    Id = 1,
                    UserInformation = new ApiUserInformationModel()
                    {
                        Id = 1,
                        IsBanned = false,
                        IsFreeTrial = false,
                        IsGaranted = false,
                        IsSubscribedExecutor = false,
                        IsSubscribedOpenSource = false,
                        LoginName = "login1",
                        Role = "user",
                        TelephoneNumber = "+375331111111"
                    },
                    Description = "desc",
                    FirstName = "fname",
                    LastName = "lname"
                }, 1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "UserService.EditProfile(invalid, 1) should return FormatException.")]
        public void UserService_EditProfile_invalid_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<FormatException>(
                    async () => await service
                                .EditProfile(new ApiUserDescriptionModel() { Id = 1 }, 1));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.EditProfile(valid, 6) should return IndexOutOfRangeException.")]
        public void UserService_EditProfile_valid_6_should_return_IndexOutOfRangeException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<IndexOutOfRangeException>(
                    async () => await service
                                .EditProfile(new ApiUserDescriptionModel()
                                {
                                    Id = 1,
                                    UserInformation = new ApiUserInformationModel()
                                    {
                                        Id = 6,
                                        IsBanned = false,
                                        IsFreeTrial = false,
                                        IsGaranted = false,
                                        IsSubscribedExecutor = false,
                                        IsSubscribedOpenSource = false,
                                        LoginName = "login1",
                                        Role = "user",
                                        TelephoneNumber = "+375331111111"
                                    },
                                    Description = "desc",
                                    FirstName = "fname",
                                    LastName = "lname"
                                }, 6));

                Assert.Equal(typeof(IndexOutOfRangeException), result.GetType());
            }
        }

        [Fact(DisplayName = "UserService.EditProfile(valid, 5) should return InvalidOperationException.")]
        public void UserService_EditProfile_valid_invalid_1_should_return_InvalidOperationException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new UserService(
                    new AttachmentRepository(Context),
                    new BanDescriptionRepository(Context),
                    new CityRepository(Context),
                    new CostRepository(Context),
                    new CountryRepository(Context),
                    new EducationRepository(Context),
                    new EducationTypeRepository(Context),
                    new EducationUserDescriptionRepository(Context),
                    new EmailDescriptionRepository(Context),
                    new ExecutorSkillRepository(Context),
                    new OpenSourceRepository(Context),
                    new OpenSourceAttachmentRepository(Context),
                    new OrderAttachmentRepository(Context),
                    new OrderDetailsRepository(Context),
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    new StateRepository(Context),
                    new SubscriptionExecutorRepository(Context),
                    new SubscriptionOpenSourceRepository(Context),
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = Assert.ThrowsAsync<InvalidOperationException>(
                    async () => await service
                                .EditProfile(new ApiUserDescriptionModel()
                                {
                                    Id = 1,
                                    UserInformation = new ApiUserInformationModel()
                                    {
                                        Id = 6,
                                        IsBanned = false,
                                        IsFreeTrial = false,
                                        IsGaranted = false,
                                        IsSubscribedExecutor = false,
                                        IsSubscribedOpenSource = false,
                                        LoginName = "login1",
                                        Role = "user",
                                        TelephoneNumber = "+375331111111"
                                    },
                                    Description = "desc",
                                    FirstName = "fname",
                                    LastName = "lname"
                                }, 5));

                Assert.Equal(typeof(InvalidOperationException), result.GetType());
            }
        }

        //TODO: AddPictureProfile, EditPictureProfile,
        //RemovePictureProfile, RequestToBuySubscription,
        //CompleteBuySubcription, AddFileToOpenSource,
        //RemoveFileFromOpenSource, AddOrder,
        //StartExecuteOrder, CloseOrder, AddReview
        //TODO: Add email and validate email.
    }
}

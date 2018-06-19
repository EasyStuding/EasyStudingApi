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
    public class ExecutorServiceTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "ExecutorService.GetApiOrderDetailsModels(null, null, 1) should return 1 object.")]
        public async void ExecutorService_GetApiOrderDetailsModels_null_null_1_should_return_1_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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
                var result = await service.GetApiOrderDetailsModels(null, null, 1);

                Assert.Equal(1, result.Count());
            }
        }

        [Fact(DisplayName = "ExecutorService.GetApiOrderDetailsModels(invalid, null, 1) should return FormatException.")]
        public void ExecutorService_GetApiOrderDetailsModels_invalid_null_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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
                                .GetApiOrderDetailsModels(
                        new ApiEducationModel() { Id = 1, City = null, Country = null, EducationName = null, Educationtype = null }, 
                        null, 
                        1));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.GetApiOrderDetailsModels(null, invalid, 1) should return FormatException.")]
        public void ExecutorService_GetApiOrderDetailsModels_null_invalid_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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
                                .GetApiOrderDetailsModels(
                        null,
                        new City() { Id = 1, CountryId = 1, Name = null, Region = null },
                        1));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.GetApiOrderDetailsModels(null, out index, 1) should return IndexOutOfRangeException.")]
        public void ExecutorService_GetApiOrderDetailsModels_null_outIndex_1_should_return_IndexOutOfRangeException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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
                                .GetApiOrderDetailsModels(
                        null,
                        new City() { Id = 7, CountryId = 1, Name = "city", Region = null },
                        1));

                Assert.Equal(typeof(IndexOutOfRangeException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.GetApiOrderDetailsModels(1, 1) should return UnauthorizedAccessException.")]
        public void ExecutorService_GetApiOrderDetailsModels_null_null_5_should_return_UnauthorizedAccessException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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
                                .GetApiOrderDetailsModels(
                        null,
                        null,
                        5));

                Assert.Equal(typeof(UnauthorizedAccessException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.GetApiOrderDetailsModel(1, 1) should return first object.")]
        public async void ExecutorService_GetApiOrderDetailsModel_1_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

        [Fact(DisplayName = "ExecutorService.GetApiOrderDetailsModel(6, 1) should return ArgumentNullException.")]
        public void ExecutorService_GetApiOrderDetailsModel_6_1_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

        [Fact(DisplayName = "ExecutorService.GetApiOrderDetailsModel(1, 5) should return UnauthorizedAccessException.")]
        public void ExecutorService_GetApiOrderDetailsModel_1_5_should_return_UnauthorizedAccessException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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
                                .GetApiOrderDetailsModel(1, 5));

                Assert.Equal(typeof(UnauthorizedAccessException), result.GetType());
            }
        }



        [Fact(DisplayName = "ExecutorService.GetTheRightsToPerformOrder(6, 1) should return requested order with id 6.")]
        public async void ExecutorService_GetTheRightsToPerformOrder_6_1_should_return_requested_order_6()
        {
            using (Context = new TestDbContext().Context)
            {
                var orderRep = new OrderDetailsRepository(Context);

                var stateRep = new StateRepository(Context);

                await stateRep.Add(new State() { Id = 6, InProgress = false, IsCompleted = false });

                await orderRep.Add(new OrderDetails() { Id = 6, CustomerId = 2, ExecutorId = null, Description = "description6", Title = "title6", StateId = 6 });

                var service = new ExecutorService(
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
                    orderRep,
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    stateRep,
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

                var result = await service.GetTheRightsToPerformOrder(6, 1);

                Assert.Equal(6, result.Id);
            }
        }

        [Fact(DisplayName = "ExecutorService.GetTheRightsToPerformOrder(7, 1) should return ArgumentNullException.")]
        public void ExecutorService_GetTheRightsToPerformOrder_7_1_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = Assert.ThrowsAsync<ArgumentNullException>(async () => await service.GetTheRightsToPerformOrder(6, 1));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.GetTheRightsToPerformOrder(3, 1) should return InvalidOperationException.")]
        public void ExecutorService_GetTheRightsToPerformOrder_3_1_should_return_InvalidOperationException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = Assert.ThrowsAsync<InvalidOperationException>(async () => await service.GetTheRightsToPerformOrder(3, 1));

                Assert.Equal(typeof(InvalidOperationException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.GetTheRightsToPerformOrder(6, 5) should return UnauthorizedAccessException.")]
        public async void ExecutorService_GetTheRightsToPerformOrder_6_5_should_return_UnauthorizedAccessException()
        {
            using (Context = new TestDbContext().Context)
            {
                var orderRep = new OrderDetailsRepository(Context);

                var stateRep = new StateRepository(Context);

                await stateRep.Add(new State() { Id = 6, InProgress = false, IsCompleted = false });

                await orderRep.Add(new OrderDetails() { Id = 6, CustomerId = 2, ExecutorId = null, Description = "description6", Title = "title6", StateId = 6 });

                var service = new ExecutorService(
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
                    orderRep,
                    new OrderSkillRepository(Context),
                    new PaymentTransactionRepository(Context),
                    new ReviewRepository(Context),
                    new RoleRepository(Context),
                    new SkillRepository(Context),
                    stateRep,
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

                var result = Assert.ThrowsAsync<UnauthorizedAccessException>(async () => await service.GetTheRightsToPerformOrder(6, 5));

                Assert.Equal(typeof(UnauthorizedAccessException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.CloseOrder(5, 1) should return requested order with id 5.")]
        public async void ExecutorService_CloseOrder_5_1_should_return_requested_order_5()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = await service.CloseOrder(5, 1);

                Assert.Equal(5, result.Id);
            }
        }

        [Fact(DisplayName = "ExecutorService.CloseOrder(6, 1) should return ArgumentNullException.")]
        public void ExecutorService_CloseOrder_6_1_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = Assert.ThrowsAsync<ArgumentNullException>(async () => await service.CloseOrder(6, 1));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.CloseOrder(3, 1) should return UnauthorizedAccessException.")]
        public void ExecutorService_CloseOrder_3_1_should_return_UnauthorizedAccessException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = Assert.ThrowsAsync<UnauthorizedAccessException>(async () => await service.CloseOrder(3, 1));

                Assert.Equal(typeof(UnauthorizedAccessException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.AddSkill(5, 1) should return requested order with id 5.")]
        public async void ExecutorService_AddSkill_5_1_should_return_requested_order_5()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = await service.AddSkill(5, 1);

                Assert.Equal(5, result.Id);
            }
        }

        [Fact(DisplayName = "ExecutorService.AddSkill(6, 1) should return ArgumentNullException.")]
        public void ExecutorService_AddSkill_6_1_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = Assert.ThrowsAsync<ArgumentNullException>(async () => await service.AddSkill(6, 1));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.AddSkill(3, 5) should return UnauthorizedAccessException.")]
        public void ExecutorService_AddSkill_3_5_should_return_UnauthorizedAccessException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = Assert.ThrowsAsync<UnauthorizedAccessException>(async () => await service.AddSkill(3, 5));

                Assert.Equal(typeof(UnauthorizedAccessException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.RemoveSkill(1, 1) should return requested order with id 1.")]
        public async void ExecutorService_RemoveSkill_1_1_should_return_requested_order_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = await service.RemoveSkill(1, 1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ExecutorService.RemoveSkill(6, 1) should return ArgumentNullException.")]
        public void ExecutorService_RemoveSkill_6_1_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = Assert.ThrowsAsync<ArgumentNullException>(async () => await service.RemoveSkill(6, 1));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorService.RemoveSkill(3, 5) should return UnauthorizedAccessException.")]
        public void ExecutorService_RemoveSkill_3_5_should_return_UnauthorizedAccessException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ExecutorService(
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

                var result = Assert.ThrowsAsync<UnauthorizedAccessException>(async () => await service.RemoveSkill(3, 5));

                Assert.Equal(typeof(UnauthorizedAccessException), result.GetType());
            }
        }
    }
}

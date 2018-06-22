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
    public class ModeratorServiceTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "ModeratorService.BanUser(1) should return first object.")]
        public async void ModeratorService_BanUser_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.BanUser(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.BanUser(7) should return ArgumentNullException.")]
        public void ModeratorService_BanUser_7_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .BanUser(7));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveBanOfUser(1) should return first object.")]
        public async void ModeratorService_RemoveBanOfUser_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.RemoveBanOfUser(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveBanOfUser(7) should return ArgumentNullException.")]
        public void ModeratorService_RemoveBanOfUser_7_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .RemoveBanOfUser(7));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.CloseOrder(1) should return first object.")]
        public async void ModeratorService_CloseOrder_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.CloseOrder(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.CloseOrder(7) should return ArgumentNullException.")]
        public void ModeratorService_CloseOrder_7_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .CloseOrder(7));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.GetApiOrderDetailsModels(null, null) should return 5 objects.")]
        public async void ModeratorService_GetApiOrderDetailsModels_null_null_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );
                var result = await service.GetApiOrderDetailsModels(null, null);

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "ModeratorService.GetApiOrderDetailsModels(invalid, null) should return FormatException.")]
        public void ModeratorService_GetApiOrderDetailsModels_invalid_null_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                        null));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.GetApiOrderDetailsModels(null, invalid) should return FormatException.")]
        public void ModeratorService_GetApiOrderDetailsModels_null_invalid_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                        new City() { Id = 1, CountryId = 1, Name = null, Region = null }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.GetApiOrderDetailsModels(null, out index) should return IndexOutOfRangeException.")]
        public void ModeratorService_GetApiOrderDetailsModels_null_outIndex_should_return_IndexOutOfRangeException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                        new City() { Id = 7, CountryId = 1, Name = "city", Region = null }));

                Assert.Equal(typeof(IndexOutOfRangeException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.GetApiOrderDetailsModel(1) should return first object.")]
        public async void ModeratorService_GetApiOrderDetailsModel_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.GetApiOrderDetailsModel(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.GetApiOrderDetailsModel(6) should return ArgumentNullException.")]
        public void ModeratorService_GetApiOrderDetailsModel_6_1_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .GetApiOrderDetailsModel(6));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.AddCountry(valid) should return object with id 6.")]
        public async void ModeratorService_AddCountry_valid_should_return_object_id_6()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.AddCountry(new Country() { Id = 6, Name = "country6" });

                Assert.Equal(6, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.AddCountry(invalid) should return FormatException.")]
        public void ModeratorService_AddCountry_invalid_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .AddCountry(new Country() { Id = 6, Name = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditCountry(valid 1) should return object with id 1.")]
        public async void ModeratorService_EditCountry_valid_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.EditCountry(new Country() { Id = 1, Name = "country1" });

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.EditCountry(invalid 1) should return FormatException.")]
        public void ModeratorService_EditCountry_invalid_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditCountry(new Country() { Id = 1, Name = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditCountry(valid 6) should return ArgumentNullException.")]
        public void ModeratorService_EditCountry_valid_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditCountry(new Country() { Id = 6, Name = "country6" }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveCountry(1) should return object with id 1.")]
        public async void ModeratorService_RemoveCountry_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.RemoveCountry(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveCountry(6) should return ArgumentNullException.")]
        public void ModeratorService_RemoveCountry_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .RemoveCountry(6));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.AddCity(valid) should return object with id 6.")]
        public async void ModeratorService_AddCity_valid_should_return_object_id_6()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.AddCity(new City() { Id = 6, Name = "city6" });

                Assert.Equal(6, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.AddCity(invalid) should return FormatException.")]
        public void ModeratorService_AddCity_invalid_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .AddCity(new City() { Id = 6, Name = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditCity(valid 1) should return object with id 1.")]
        public async void ModeratorService_EditCity_valid_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.EditCity(new City() { Id = 1, Name = "city1" });

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.EditCity(invalid 1) should return FormatException.")]
        public void ModeratorService_EditCity_invalid_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                  new SubscriptionRepository(Context),
                  
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
                                .EditCity(new City() { Id = 1, Name = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditCity(valid 6) should return ArgumentNullException.")]
        public void ModeratorService_EditCity_valid_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditCity(new City() { Id = 6, Name = "city6" }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveCity(1) should return object with id 1.")]
        public async void ModeratorService_RemoveCity_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.RemoveCity(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveCity(6) should return ArgumentNullException.")]
        public void ModeratorService_RemoveCity_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .RemoveCity(6));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.AddEducationType(valid) should return object with id 3.")]
        public async void ModeratorService_AddEducationType_valid_should_return_object_id_3()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.AddEducationType(new EducationType() { Id = 3, Name = "et3" });

                Assert.Equal(3, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.AddEducationType(invalid) should return FormatException.")]
        public void ModeratorService_AddEducationType_invalid_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .AddEducationType(new EducationType() { Id = 3, Name = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditEducationtype(valid 1) should return object with id 1.")]
        public async void ModeratorService_EditEducationtype_valid_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.EditEducationtype(new EducationType() { Id = 1, Name = "et1" });

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.EditEducationtype(invalid 1) should return FormatException.")]
        public void ModeratorService_EditEducationtype_invalid_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditEducationtype(new EducationType() { Id = 1, Name = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditEducationtype(valid 6) should return ArgumentNullException.")]
        public void ModeratorService_EditEducationtype_valid_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditCountry(new Country() { Id = 6, Name = "country6" }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveEducationType(1) should return object with id 1.")]
        public async void ModeratorService_RemoveEducationType_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.RemoveEducationType(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveEducationType(6) should return ArgumentNullException.")]
        public void ModeratorService_RemoveEducationType_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .RemoveEducationType(6));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.AddEducation(valid) should return object with id 6.")]
        public async void ModeratorService_AddEducation_valid_should_return_object_id_6()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.AddEducation(
                    new ApiEducationModel() {
                        Id = 6,
                        City = new City() { Id = 1, CountryId = 1, Name = "asdf", Region = "asdf" },
                        EducationName = "e1",
                        Educationtype = new EducationType() { Id = 1, Name = "safd" } });

                Assert.Equal(6, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.AddEducation(invalid) should return FormatException.")]
        public void ModeratorService_AddEducation_invalid_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .AddEducation(new ApiEducationModel() { Id = 6 }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditEducation(valid 1) should return object with id 1.")]
        public async void ModeratorService_EditEducation_valid_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.EditEducation(new ApiEducationModel() {
                    Id = 1,
                    City = new City() { Id = 1, CountryId = 1, Name = "asdf", Region = "asdf" },
                    EducationName = "e1",
                    Educationtype = new EducationType() { Id = 1, Name = "safd" }
                });

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.EditEducation(invalid 1) should return FormatException.")]
        public void ModeratorService_EditEducation_invalid_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditEducation(new ApiEducationModel() { Id = 1 }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditEducation(valid 6) should return ArgumentNullException.")]
        public void ModeratorService_EditEducation_valid_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditEducation(new ApiEducationModel() {
                                    Id = 6,
                                    City = new City() { Id = 1, CountryId = 1, Name = "asdf", Region = "asdf" },
                                    EducationName = "e1",
                                    Educationtype = new EducationType() { Id = 1, Name = "safd" }
                                }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveEducation(1) should return object with id 1.")]
        public async void ModeratorService_RemoveEducation_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.RemoveEducation(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveEducation(6) should return ArgumentNullException.")]
        public void ModeratorService_RemoveEducation_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .RemoveEducation(6));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.AddCost(valid) should return object with id 6.")]
        public async void ModeratorService_AddCost_valid_should_return_object_id_6()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.AddCost(new Cost() { Id = 3, Money = 5, Product = "product3" });

                Assert.Equal(3, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.AddCost(invalid) should return FormatException.")]
        public void ModeratorService_AddCost_invalid_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .AddCost(new Cost() { Id = 3, Money = 1, Product = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditCost(valid 1) should return object with id 1.")]
        public async void ModeratorService_EditCost_valid_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.EditCost(new Cost() { Id = 1, Money = 5, Product = "asdf" });

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.EditCost(invalid 1) should return FormatException.")]
        public void ModeratorService_EditCost_invalid_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditCost(new Cost() { Id = 1, Money = 5, Product = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditCost(valid 6) should return ArgumentNullException.")]
        public void ModeratorService_EditCost_valid_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditCost(new Cost() { Id = 6, Money = 5, Product = "asdf" }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveCost(1) should return object with id 1.")]
        public async void ModeratorService_RemoveCost_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.RemoveCost(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveCost(6) should return ArgumentNullException.")]
        public void ModeratorService_RemoveCost_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .RemoveCost(6));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.AddSkill(valid) should return object with id 6.")]
        public async void ModeratorService_AddSkill_valid_should_return_object_id_6()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.AddSkill(new Skill() { Id = 6, Name = "skill6" });

                Assert.Equal(6, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.AddSkill(invalid) should return FormatException.")]
        public void ModeratorService_AddSkill_invalid_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .AddSkill(new Skill() { Id = 6, Name = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditSkill(valid 1) should return object with id 1.")]
        public async void ModeratorService_EditSkill_valid_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.EditSkill(new Skill() { Id = 1, Name = "skill1" });

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.EditSkill(invalid 1) should return FormatException.")]
        public void ModeratorService_EditSkill_invalid_1_should_return_FormatException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditSkill(new Skill() { Id = 1, Name = "" }));

                Assert.Equal(typeof(FormatException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.EditSkill(valid 6) should return ArgumentNullException.")]
        public void ModeratorService_EditSkill_valid_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .EditSkill(new Skill() { Id = 6, Name = "country6" }));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveSkill(1) should return object with id 1.")]
        public async void ModeratorService_RemoveSkill_1_should_return_object_id_1()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
                    new UserDescriptionRepository(Context),
                    new UserInformationRepository(Context),
                    new UserPictureRepository(Context),
                    new UserRegistrationRepository(Context),
                    new ValidationEmailRepository(Context),
                    new ValidationUserRepository(Context),
                    new CloseTransactionRepository(Context),
                    new OpenTransactionRepository(Context)
                    );

                var result = await service.RemoveSkill(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ModeratorService.RemoveSkill(6) should return ArgumentNullException.")]
        public void ModeratorService_RemoveSkill_6_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var service = new ModeratorService(
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
                    new SubscriptionRepository(Context),
                    
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
                                .RemoveSkill(6));

                Assert.Equal(typeof(ArgumentNullException), result.GetType());
            }
        }
    }
}

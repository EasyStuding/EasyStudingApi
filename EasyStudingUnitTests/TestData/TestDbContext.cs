using System;
using System.Collections.Generic;
using System.Text;
using EasyStudingRepositories.DbContext;
using EasyStudingModels.DbContextModels;
using Microsoft.EntityFrameworkCore;

namespace EasyStudingUnitTests.TestData
{
    public class TestDbContext
    {
        public EasyStudingContext Context;

        public TestDbContext()
        {
            var options = new DbContextOptionsBuilder<EasyStudingContext>()
                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
                  .Options;

            Context = new EasyStudingContext(options);

            CreateUserRegistrations();

            CreateValidationUsers();

            CreateRoles();

            CreateCosts();

            CreateAttachments();

            CreateSubscriptionExecutors();

            CreateSubscriptionOpenSources();

            CreateOpenSources();

            CreateUserInformations();

            CreateBanDescriptions();

            CreateReviews();

            CreateCountries();

            CreateCities();

            CreateEducationTypes();

            CreateEducations();

            CreateEducationUserDescriptions();

            CreateEmailDescriptions();

            CreateValidationEmails();

            CreateUserDescriptions();

            CreateUserPictures();

            CreateSkills();

            CreateExecutorSkills();

            CreateStates();

            CreateOrderDetails();

            CreateOrderSkills();

            CreateOrderAttachments();

            CreateOpenSourceAttachments();

            CreatePaymentTransactions();

            CreateCloseTransactions();

            CreateOpenTransactions();
        }

        private void CreateUserRegistrations()
        {
            Context.UserRegistrations.Add(
                new UserRegistration() { Id = 1, TelephoneNumber = "+375291111111", RegistrationDate = DateTime.Now, IsValidated = true });

            Context.UserRegistrations.Add(
                new UserRegistration() { Id = 2, TelephoneNumber = "+375292222222", RegistrationDate = DateTime.Now, IsValidated = true });

            Context.UserRegistrations.Add(
                new UserRegistration() { Id = 3, TelephoneNumber = "+375293333333", RegistrationDate = DateTime.Now, IsValidated = true });

            Context.UserRegistrations.Add(
                new UserRegistration() { Id = 4, TelephoneNumber = "+375294444444", RegistrationDate = DateTime.Now, IsValidated = false });

            Context.UserRegistrations.Add(
                new UserRegistration() { Id = 5, TelephoneNumber = "+375295555555", RegistrationDate = DateTime.Now, IsValidated = false });

            Context.SaveChanges();
        }

        private void CreateValidationUsers()
        {
            Context.ValidationUsers.Add(new ValidationUser() { Id = 1, UserRegistrationId = 1, ValidationCode = "111111" });
            Context.ValidationUsers.Add(new ValidationUser() { Id = 2, UserRegistrationId = 2, ValidationCode = "222222" });
            Context.ValidationUsers.Add(new ValidationUser() { Id = 3, UserRegistrationId = 3, ValidationCode = "333333" });
            Context.ValidationUsers.Add(new ValidationUser() { Id = 4, UserRegistrationId = 4, ValidationCode = "444444" });
            Context.ValidationUsers.Add(new ValidationUser() { Id = 5, UserRegistrationId = 5, ValidationCode = "555555" });

            Context.SaveChanges();
        }

        private void CreateRoles()
        {
            Context.Roles.Add(new Role() { Id = 1, Name = "user" });
            Context.Roles.Add(new Role() { Id = 2, Name = "moderator" });
            Context.Roles.Add(new Role() { Id = 3, Name = "admin" });

            Context.SaveChanges();
        }

        private void CreateCosts()
        {
            Context.Costs.Add(new Cost() { Id = 1, Money = 5, Product = "OpenSource" });
            Context.Costs.Add(new Cost() { Id = 2, Money = 10, Product = "Executor" });

            Context.SaveChanges();
        }

        private void CreateAttachments()
        {
            Context.Attachments.Add(new Attachment() { Id = 1, Type = "jpg", Ref = "https://example.com/1" });
            Context.Attachments.Add(new Attachment() { Id = 2, Type = "bmp", Ref = "https://example.com/2" });
            Context.Attachments.Add(new Attachment() { Id = 3, Type = "png", Ref = "https://example.com/3" });
            Context.Attachments.Add(new Attachment() { Id = 4, Type = "txt", Ref = "https://example.com/4" });
            Context.Attachments.Add(new Attachment() { Id = 5, Type = "doc", Ref = "https://example.com/5" });

            Context.SaveChanges();
        }

        private void CreateSubscriptionExecutors()
        {
            Context.SubscriptionExecutors.Add(new SubscriptionExecutor() { Id = 1, CostId = 2, DateExpires = DateTime.Now, IsActive = true });
            Context.SubscriptionExecutors.Add(new SubscriptionExecutor() { Id = 2, CostId = 2, DateExpires = DateTime.Now, IsActive = true });
            Context.SubscriptionExecutors.Add(new SubscriptionExecutor() { Id = 3, CostId = 2, DateExpires = DateTime.Now, IsActive = true });
            Context.SubscriptionExecutors.Add(new SubscriptionExecutor() { Id = 4, CostId = 2, DateExpires = DateTime.Now, IsActive = true });
            Context.SubscriptionExecutors.Add(new SubscriptionExecutor() { Id = 5, CostId = 2, DateExpires = DateTime.Now, IsActive = true });

            Context.SaveChanges();
        }

        private void CreateSubscriptionOpenSources()
        {
            Context.SubscriptionOpenSources.Add(new SubscriptionOpenSource() { Id = 1, CostId = 1, DateExpires = DateTime.Now, IsActive = true });
            Context.SubscriptionOpenSources.Add(new SubscriptionOpenSource() { Id = 2, CostId = 1, DateExpires = DateTime.Now, IsActive = true });
            Context.SubscriptionOpenSources.Add(new SubscriptionOpenSource() { Id = 3, CostId = 1, DateExpires = DateTime.Now, IsActive = true });
            Context.SubscriptionOpenSources.Add(new SubscriptionOpenSource() { Id = 4, CostId = 1, DateExpires = DateTime.Now, IsActive = true });
            Context.SubscriptionOpenSources.Add(new SubscriptionOpenSource() { Id = 5, CostId = 1, DateExpires = DateTime.Now, IsActive = true });

            Context.SaveChanges();
        }

        private void CreateOpenSources()
        {
            Context.OpenSources.Add(new OpenSource() { Id = 1, OpenSourceSubscriptionId = 1 });
            Context.OpenSources.Add(new OpenSource() { Id = 2, OpenSourceSubscriptionId = 2 });
            Context.OpenSources.Add(new OpenSource() { Id = 3, OpenSourceSubscriptionId = 3 });
            Context.OpenSources.Add(new OpenSource() { Id = 4, OpenSourceSubscriptionId = 4 });
            Context.OpenSources.Add(new OpenSource() { Id = 5, OpenSourceSubscriptionId = 5 });

            Context.SaveChanges();
        }

        private void CreateUserInformations()
        {
            Context.UserInformations.Add(new UserInformation() {
                Id = 1, UserRegistrationId = 1,
                SubscriptionExecutorId = 1, OpenSourceId = 1,
                RoleId = 1, LoginName = "login1",
                Password = "password1", IsGaranted = false,
                IsFreeTrial = false, IsBanned = false});

            Context.UserInformations.Add(new UserInformation() {
                Id = 2, UserRegistrationId = 2,
                SubscriptionExecutorId = 2, OpenSourceId = 2,
                RoleId = 1, LoginName = "login2",
                Password = "password2", IsGaranted = false,
                IsFreeTrial = false, IsBanned = false });

            Context.UserInformations.Add(new UserInformation() {
                Id = 3, UserRegistrationId = 3,
                SubscriptionExecutorId = 3, OpenSourceId = 3,
                RoleId = 1, LoginName = "login3",
                Password = "password3", IsGaranted = false,
                IsFreeTrial = false, IsBanned = false });

            Context.UserInformations.Add(new UserInformation() {
                Id = 4, UserRegistrationId = 4,
                SubscriptionExecutorId = 4, OpenSourceId = 4,
                RoleId = 1, LoginName = "login4",
                Password = "password4", IsGaranted = false,
                IsFreeTrial = false, IsBanned = false });

            Context.UserInformations.Add(new UserInformation() {
                Id = 5, UserRegistrationId = 5,
                SubscriptionExecutorId = 5, OpenSourceId = 5,
                RoleId = 1, LoginName = "login5",
                Password = "password5", IsGaranted = false,
                IsFreeTrial = false, IsBanned = false });

            Context.SaveChanges();
        }

        private void CreateBanDescriptions()
        {
            Context.BanDescriptions.Add(new BanDescription() { Id = 1, UserInformationId = 1, ExpiresDate = DateTime.Now });
            Context.BanDescriptions.Add(new BanDescription() { Id = 2, UserInformationId = 2, ExpiresDate = DateTime.Now });
            Context.BanDescriptions.Add(new BanDescription() { Id = 3, UserInformationId = 3, ExpiresDate = DateTime.Now });
            Context.BanDescriptions.Add(new BanDescription() { Id = 4, UserInformationId = 4, ExpiresDate = DateTime.Now });
            Context.BanDescriptions.Add(new BanDescription() { Id = 5, UserInformationId = 5, ExpiresDate = DateTime.Now });

            Context.SaveChanges();
        }

        private void CreateReviews()
        {
            Context.Reviews.Add(new Review() { Id = 1, ReviewOwnerId = 1, ReviewRecipientId = 2, Title = "title1", Description = "Description1", Raiting = 5 });
            Context.Reviews.Add(new Review() { Id = 2, ReviewOwnerId = 2, ReviewRecipientId = 3, Title = "title2", Description = "Description2", Raiting = 5 });
            Context.Reviews.Add(new Review() { Id = 3, ReviewOwnerId = 3, ReviewRecipientId = 4, Title = "title3", Description = "Description3", Raiting = 5 });
            Context.Reviews.Add(new Review() { Id = 4, ReviewOwnerId = 4, ReviewRecipientId = 5, Title = "title4", Description = "Description4", Raiting = 5 });
            Context.Reviews.Add(new Review() { Id = 5, ReviewOwnerId = 5, ReviewRecipientId = 1, Title = "title5", Description = "Description5", Raiting = 5 });

            Context.SaveChanges();
        }

        private void CreateCountries()
        {
            Context.Countries.Add(new Country() { Id = 1, Name = "USA" });
            Context.Countries.Add(new Country() { Id = 2, Name = "Belarus" });
            Context.Countries.Add(new Country() { Id = 3, Name = "Russia" });
            Context.Countries.Add(new Country() { Id = 4, Name = "China" });
            Context.Countries.Add(new Country() { Id = 5, Name = "UK" });

            Context.SaveChanges();
        }

        private void CreateCities()
        {
            Context.Cities.Add(new City() { Id = 1, CountryId = 1, Name = "Boston" });
            Context.Cities.Add(new City() { Id = 2, CountryId = 2, Name = "Brest" });
            Context.Cities.Add(new City() { Id = 3, CountryId = 3, Name = "Vladivostok" });
            Context.Cities.Add(new City() { Id = 4, CountryId = 4, Name = "Gonkong" });
            Context.Cities.Add(new City() { Id = 5, CountryId = 5, Name = "London" });

            Context.SaveChanges();
        }

        private void CreateEducationTypes()
        {
            Context.EducationTypes.Add(new EducationType() { Id = 1, Name = "school" });
            Context.EducationTypes.Add(new EducationType() { Id = 2, Name = "university" });

            Context.SaveChanges();
        }

        private void CreateEducations()
        {
            Context.Educations.Add(new Education() { Id = 1, EducationTypeId = 1, CityId = 1, EducationName = "S1" });
            Context.Educations.Add(new Education() { Id = 2, EducationTypeId = 2, CityId = 2, EducationName = "U2" });
            Context.Educations.Add(new Education() { Id = 3, EducationTypeId = 1, CityId = 3, EducationName = "S3" });
            Context.Educations.Add(new Education() { Id = 4, EducationTypeId = 2, CityId = 4, EducationName = "U4" });
            Context.Educations.Add(new Education() { Id = 5, EducationTypeId = 1, CityId = 5, EducationName = "S5" });

            Context.SaveChanges();
        }

        private void CreateEducationUserDescriptions()
        {
            Context.EducationUserDescriptions.Add(new EducationUserDescription() { Id = 1, EducationId = 1, AdmissionDate = DateTime.Now, GraduationDate = DateTime.Now });
            Context.EducationUserDescriptions.Add(new EducationUserDescription() { Id = 2, EducationId = 2, AdmissionDate = DateTime.Now, GraduationDate = DateTime.Now });
            Context.EducationUserDescriptions.Add(new EducationUserDescription() { Id = 3, EducationId = 3, AdmissionDate = DateTime.Now, GraduationDate = DateTime.Now });
            Context.EducationUserDescriptions.Add(new EducationUserDescription() { Id = 4, EducationId = 4, AdmissionDate = DateTime.Now, GraduationDate = DateTime.Now });
            Context.EducationUserDescriptions.Add(new EducationUserDescription() { Id = 5, EducationId = 5, AdmissionDate = DateTime.Now, GraduationDate = DateTime.Now });

            Context.SaveChanges();
        }

        private void CreateEmailDescriptions()
        {
            Context.EmailDescriptions.Add(new EmailDescription() { Id = 1, Email = "email1", IsValidated = true });
            Context.EmailDescriptions.Add(new EmailDescription() { Id = 2, Email = "email2", IsValidated = true });
            Context.EmailDescriptions.Add(new EmailDescription() { Id = 3, Email = "email3", IsValidated = true });
            Context.EmailDescriptions.Add(new EmailDescription() { Id = 4, Email = "email4", IsValidated = true });
            Context.EmailDescriptions.Add(new EmailDescription() { Id = 5, Email = "email5", IsValidated = true });

            Context.SaveChanges();
        }

        private void CreateValidationEmails()
        {
            Context.ValidationEmails.Add(new ValidationEmail() { Id = 1, EmailDescriptionId = 1, ValidateCode = "111111" });
            Context.ValidationEmails.Add(new ValidationEmail() { Id = 2, EmailDescriptionId = 2, ValidateCode = "222222" });
            Context.ValidationEmails.Add(new ValidationEmail() { Id = 3, EmailDescriptionId = 3, ValidateCode = "333333" });
            Context.ValidationEmails.Add(new ValidationEmail() { Id = 4, EmailDescriptionId = 4, ValidateCode = "444444" });
            Context.ValidationEmails.Add(new ValidationEmail() { Id = 5, EmailDescriptionId = 5, ValidateCode = "555555" });

            Context.SaveChanges();
        }

        private void CreateUserDescriptions()
        {
            Context.UserDescriptions.Add(new UserDescription() {
                Id = 1, EducationUserDecriptionId = 1,
                EmailDescriptionId = 1, CityId = 1,
                UserInformationId = 1, Description = "description1",
                FirstName = "fname1", LastName = "lname1" });

            Context.UserDescriptions.Add(new UserDescription() {
                Id = 2, EducationUserDecriptionId = 2,
                EmailDescriptionId = 2, CityId = 2,
                UserInformationId = 2, Description = "description2",
                FirstName = "fname2", LastName = "lname2" });

            Context.UserDescriptions.Add(new UserDescription() {
                Id = 3, EducationUserDecriptionId = 3,
                EmailDescriptionId = 3, CityId = 3,
                UserInformationId = 3, Description = "description3",
                FirstName = "fname3", LastName = "lname3" });

            Context.UserDescriptions.Add(new UserDescription() {
                Id = 4, EducationUserDecriptionId = 4,
                EmailDescriptionId = 4, CityId = 4,
                UserInformationId = 4, Description = "description4",
                FirstName = "fname4", LastName = "lname4" });

            Context.UserDescriptions.Add(new UserDescription() {
                Id = 5, EducationUserDecriptionId = 5,
                EmailDescriptionId = 5, CityId = 5,
                UserInformationId = 5, Description = "description5",
                FirstName = "fname5", LastName = "lname5" });

            Context.SaveChanges();
        }

        private void CreateUserPictures()
        {
            Context.UserPictures.Add(new UserPicture() { Id = 1, UserInformationId = 1, Ref = "https://example.com/picture/1" });
            Context.UserPictures.Add(new UserPicture() { Id = 2, UserInformationId = 1, Ref = "https://example.com/picture/2" });
            Context.UserPictures.Add(new UserPicture() { Id = 3, UserInformationId = 1, Ref = "https://example.com/picture/3" });
            Context.UserPictures.Add(new UserPicture() { Id = 4, UserInformationId = 1, Ref = "https://example.com/picture/4" });
            Context.UserPictures.Add(new UserPicture() { Id = 5, UserInformationId = 1, Ref = "https://example.com/picture/5" });

            Context.SaveChanges();
        }

        private void CreateSkills()
        {
            Context.Skills.Add(new Skill() { Id = 1, Name = "skill1" });
            Context.Skills.Add(new Skill() { Id = 2, Name = "skill2" });
            Context.Skills.Add(new Skill() { Id = 3, Name = "skill3" });
            Context.Skills.Add(new Skill() { Id = 4, Name = "skill4" });
            Context.Skills.Add(new Skill() { Id = 5, Name = "skill5" });

            Context.SaveChanges();
        }

        private void CreateExecutorSkills()
        {
            Context.ExecutorSkills.Add(new ExecutorSkill() { Id = 1, SubscriptionExecutorId = 1, SkillId = 1 });
            Context.ExecutorSkills.Add(new ExecutorSkill() { Id = 2, SubscriptionExecutorId = 2, SkillId = 2 });
            Context.ExecutorSkills.Add(new ExecutorSkill() { Id = 3, SubscriptionExecutorId = 3, SkillId = 3 });
            Context.ExecutorSkills.Add(new ExecutorSkill() { Id = 4, SubscriptionExecutorId = 4, SkillId = 4 });
            Context.ExecutorSkills.Add(new ExecutorSkill() { Id = 5, SubscriptionExecutorId = 5, SkillId = 5 });

            Context.SaveChanges();
        }

        private void CreateStates()
        {
            Context.States.Add(new State() { Id = 1, InProgress = false, IsCompleted = true });
            Context.States.Add(new State() { Id = 2, InProgress = false, IsCompleted = true });
            Context.States.Add(new State() { Id = 3, InProgress = false, IsCompleted = true });
            Context.States.Add(new State() { Id = 4, InProgress = false, IsCompleted = true });
            Context.States.Add(new State() { Id = 5, InProgress = false, IsCompleted = true });

            Context.SaveChanges();
        }

        private void CreateOrderDetails()
        {
            Context.OrderDetails.Add(new OrderDetails() { Id = 1, CustomerId = 1, ExecutorId = 2, StateId = 1, Description = "description1", Title = "title1" });
            Context.OrderDetails.Add(new OrderDetails() { Id = 2, CustomerId = 2, ExecutorId = 3, StateId = 2, Description = "description2", Title = "title2" });
            Context.OrderDetails.Add(new OrderDetails() { Id = 3, CustomerId = 3, ExecutorId = 4, StateId = 3, Description = "description3", Title = "title3" });
            Context.OrderDetails.Add(new OrderDetails() { Id = 4, CustomerId = 4, ExecutorId = 5, StateId = 4, Description = "description4", Title = "title4" });
            Context.OrderDetails.Add(new OrderDetails() { Id = 5, CustomerId = 5, ExecutorId = 1, StateId = 5, Description = "description5", Title = "title5" });

            Context.SaveChanges();
        }

        private void CreateOrderSkills()
        {
            Context.OrderSkills.Add(new OrderSkill() { Id = 1, OrderId = 1, SkillId = 1 });
            Context.OrderSkills.Add(new OrderSkill() { Id = 2, OrderId = 2, SkillId = 2 });
            Context.OrderSkills.Add(new OrderSkill() { Id = 3, OrderId = 3, SkillId = 3 });
            Context.OrderSkills.Add(new OrderSkill() { Id = 4, OrderId = 4, SkillId = 4 });
            Context.OrderSkills.Add(new OrderSkill() { Id = 5, OrderId = 5, SkillId = 5 });

            Context.SaveChanges();
        }

        private void CreateOrderAttachments()
        {
            Context.OrderAttachments.Add(new OrderAttachment() { Id = 1, OrderId = 1, AttachmentId = 1 });
            Context.OrderAttachments.Add(new OrderAttachment() { Id = 2, OrderId = 2, AttachmentId = 2 });
            Context.OrderAttachments.Add(new OrderAttachment() { Id = 3, OrderId = 3, AttachmentId = 3 });
            Context.OrderAttachments.Add(new OrderAttachment() { Id = 4, OrderId = 4, AttachmentId = 4 });
            Context.OrderAttachments.Add(new OrderAttachment() { Id = 5, OrderId = 5, AttachmentId = 5 });

            Context.SaveChanges();
        }

        private void CreateOpenSourceAttachments()
        {
            Context.OpenSourceAttachments.Add(new OpenSourceAttachment() { Id = 1, OpenSourceId = 1, AttachmentId = 1 });
            Context.OpenSourceAttachments.Add(new OpenSourceAttachment() { Id = 2, OpenSourceId = 2, AttachmentId = 2 });
            Context.OpenSourceAttachments.Add(new OpenSourceAttachment() { Id = 3, OpenSourceId = 3, AttachmentId = 3 });
            Context.OpenSourceAttachments.Add(new OpenSourceAttachment() { Id = 4, OpenSourceId = 4, AttachmentId = 4 });
            Context.OpenSourceAttachments.Add(new OpenSourceAttachment() { Id = 5, OpenSourceId = 5, AttachmentId = 5 });

            Context.SaveChanges();
        }

        private void CreatePaymentTransactions()
        {
            Context.PaymentTransactions.Add(new PaymentTransaction() { Id = 1, UserinformationId = 1, CostId = 1, IsPaid = true });
            Context.PaymentTransactions.Add(new PaymentTransaction() { Id = 2, UserinformationId = 2, CostId = 2, IsPaid = true });
            Context.PaymentTransactions.Add(new PaymentTransaction() { Id = 3, UserinformationId = 3, CostId = 1, IsPaid = true });
            Context.PaymentTransactions.Add(new PaymentTransaction() { Id = 4, UserinformationId = 4, CostId = 2, IsPaid = true });
            Context.PaymentTransactions.Add(new PaymentTransaction() { Id = 5, UserinformationId = 5, CostId = 1, IsPaid = true });

            Context.SaveChanges();
        }

        private void CreateCloseTransactions()
        {
            Context.CloseTransactions.Add(new CloseTransaction() { Id = 1, OrderDetailsId = 1, IsClosedByCustomer = true, IsClosedByExecutor = true });
            Context.CloseTransactions.Add(new CloseTransaction() { Id = 2, OrderDetailsId = 2, IsClosedByCustomer = true, IsClosedByExecutor = true });
            Context.CloseTransactions.Add(new CloseTransaction() { Id = 3, OrderDetailsId = 3, IsClosedByCustomer = true, IsClosedByExecutor = true });
            Context.CloseTransactions.Add(new CloseTransaction() { Id = 4, OrderDetailsId = 4, IsClosedByCustomer = true, IsClosedByExecutor = true });
            Context.CloseTransactions.Add(new CloseTransaction() { Id = 5, OrderDetailsId = 5, IsClosedByCustomer = true, IsClosedByExecutor = true });

            Context.SaveChanges();
        }

        private void CreateOpenTransactions()
        {
            Context.OpenTransactions.Add(new OpenTransaction() { Id = 1, OrderDetailsId = 1, IsOpenedByCustomer = true, IsOpenedByExecutor = true });
            Context.OpenTransactions.Add(new OpenTransaction() { Id = 2, OrderDetailsId = 2, IsOpenedByCustomer = true, IsOpenedByExecutor = true });
            Context.OpenTransactions.Add(new OpenTransaction() { Id = 3, OrderDetailsId = 3, IsOpenedByCustomer = true, IsOpenedByExecutor = true });
            Context.OpenTransactions.Add(new OpenTransaction() { Id = 4, OrderDetailsId = 4, IsOpenedByCustomer = true, IsOpenedByExecutor = true });
            Context.OpenTransactions.Add(new OpenTransaction() { Id = 5, OrderDetailsId = 5, IsOpenedByCustomer = true, IsOpenedByExecutor = true });

            Context.SaveChanges();
        }
    }
}

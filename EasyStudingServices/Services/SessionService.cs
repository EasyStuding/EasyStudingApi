using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingServices.Services
{
    public class SessionService: ISessionService
    {
        private readonly IRepository<Attachment> AttachmentRepository;
        private readonly IRepository<BanDescription> BanDescriptionRepository;
        private readonly IRepository<City> CityRepository;
        private readonly IRepository<Cost> CostRepository;
        private readonly IRepository<Country> CountryRepository;
        private readonly IRepository<Education> EducationRepository;
        private readonly IRepository<EducationType> EducationTypeRepository;
        private readonly IRepository<EducationUserDescription> EducationUserDescriptionRepository;
        private readonly IRepository<EmailDescription> EmailDescriptionRepository;
        private readonly IRepository<ExecutorSkill> ExecutorSkillRepository;
        private readonly IRepository<OpenSource> OpenSourceRepository;
        private readonly IRepository<OpenSourceAttachment> OpenSourceAttachmentRepository;
        private readonly IRepository<OrderAttachment> OrderAttachmentRepository;
        private readonly IRepository<OrderDetails> OrderDetailsRepository;
        private readonly IRepository<OrderSkill> OrderSkillRepository;
        private readonly IRepository<PaymentTransaction> PaymentTransactionRepository;
        private readonly IRepository<Review> ReviewRepository;
        private readonly IRepository<Role> RoleRepository;
        private readonly IRepository<Skill> SkillRepository;
        private readonly IRepository<State> StateRepository;
        private readonly IRepository<SubscriptionExecutor> SubscriptionExecutorRepository;
        private readonly IRepository<SubscriptionOpenSource> SubscriptionOpenSourceRepository;
        private readonly IRepository<UserDescription> UserDescriptionRepository;
        private readonly IRepository<UserInformation> UserInformationRepository;
        private readonly IRepository<UserPicture> UserPictureRepository;
        private readonly IRepository<UserRegistration> UserRegistrationRepository;
        private readonly IRepository<ValidationEmail> ValidationEmailRepository;
        private readonly IRepository<ValidationUser> ValidationUserRepository;
        private readonly IRepository<CloseTransaction> CloseTransactionRepository;
        private readonly IRepository<OpenTransaction> OpenTransactionRepository;

        public SessionService(
        IRepository<Attachment> AttachmentRepository,
        IRepository<BanDescription> BanDescriptionRepository,
        IRepository<City> CityRepository,
        IRepository<Cost> CostRepository,
        IRepository<Country> CountryRepository,
        IRepository<Education> EducationRepository,
        IRepository<EducationType> EducationTypeRepository,
        IRepository<EducationUserDescription> EducationUserDescriptionRepository,
        IRepository<EmailDescription> EmailDescriptionRepository,
        IRepository<ExecutorSkill> ExecutorSkillRepository,
        IRepository<OpenSource> OpenSourceRepository,
        IRepository<OpenSourceAttachment> OpenSourceAttachmentRepository,
        IRepository<OrderAttachment> OrderAttachmentRepository,
        IRepository<OrderDetails> OrderDetailsRepository,
        IRepository<OrderSkill> OrderSkillRepository,
        IRepository<PaymentTransaction> PaymentTransactionRepository,
        IRepository<Review> ReviewRepository,
        IRepository<Role> RoleRepository,
        IRepository<Skill> SkillRepository,
        IRepository<State> StateRepository,
        IRepository<SubscriptionExecutor> SubscriptionExecutorRepository,
        IRepository<SubscriptionOpenSource> SubscriptionOpenSourceRepository,
        IRepository<UserDescription> UserDescriptionRepository,
        IRepository<UserInformation> UserInformationRepository,
        IRepository<UserPicture> UserPictureRepository,
        IRepository<UserRegistration> UserRegistrationRepository,
        IRepository<ValidationEmail> ValidationEmailRepository,
        IRepository<ValidationUser> ValidationUserRepository,
        IRepository<CloseTransaction> CloseTransactionRepository,
        IRepository<OpenTransaction> OpenTransactionRepository)
        {
            this.AttachmentRepository = AttachmentRepository;
            this.BanDescriptionRepository = BanDescriptionRepository;
            this.CityRepository = CityRepository;
            this.CostRepository = CostRepository;
            this.CountryRepository = CountryRepository;
            this.EducationRepository = EducationRepository;
            this.EducationTypeRepository = EducationTypeRepository;
            this.EducationUserDescriptionRepository = EducationUserDescriptionRepository;
            this.EmailDescriptionRepository = EmailDescriptionRepository;
            this.ExecutorSkillRepository = ExecutorSkillRepository;
            this.OpenSourceRepository = OpenSourceRepository;
            this.OpenSourceAttachmentRepository = OpenSourceAttachmentRepository;
            this.OrderAttachmentRepository = OrderAttachmentRepository;
            this.OrderDetailsRepository = OrderDetailsRepository;
            this.OrderSkillRepository = OrderSkillRepository;
            this.PaymentTransactionRepository = PaymentTransactionRepository;
            this.ReviewRepository = ReviewRepository;
            this.RoleRepository = RoleRepository;
            this.SkillRepository = SkillRepository;
            this.StateRepository = StateRepository;
            this.SubscriptionExecutorRepository = SubscriptionExecutorRepository;
            this.SubscriptionOpenSourceRepository = SubscriptionOpenSourceRepository;
            this.UserDescriptionRepository = UserDescriptionRepository;
            this.UserInformationRepository = UserInformationRepository;
            this.UserPictureRepository = UserPictureRepository;
            this.UserRegistrationRepository = UserRegistrationRepository;
            this.ValidationEmailRepository = ValidationEmailRepository;
            this.ValidationUserRepository = ValidationUserRepository;
            this.CloseTransactionRepository = CloseTransactionRepository;
            this.OpenTransactionRepository = OpenTransactionRepository;
        }

        /// <summary>
        ///   Start registration by phone number.
        /// </summary>
        /// <param name="apiUserRegistration">Model of registration user.</param>
        /// <returns>
        ///    Not validated user registration profile.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>

        public async Task<UserRegistration> StartRegistration(ApiUserRegistrationModel apiUserRegistration)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Validate validation code of user.
        /// </summary>
        /// <param name="apiUserRegistration">Model of registration user.</param>
        /// <returns>
        ///    Validated user registration profile.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.InvalidOperationException">When validation code from model not equal validation code from db.</exception>

        public async Task<UserRegistration> ValidateRegistration(ValidationUser validationUser)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Create InformationModel for user.
        /// </summary>
        /// <param name="apiRegistrationLogin">Registration of login model.</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.InvalidOperationException">When user with this login contains in db.</exception>

        public async Task<ApiLoginToken> CompleteRegistration(ApiRegisrtationLoginModel apiRegistrationLogin)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get connection token to server.
        /// </summary>
        /// <param name="apiLogin">Login model.</param>
        /// <param name="isTelephone">Check condition(telephone/login).</param>
        /// <returns>
        ///    Connection token to server.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<ApiLoginToken> Login(ApiLoginModel apiLogin, bool isTelephone)
        {
            throw new Exception();
        }
    }
}

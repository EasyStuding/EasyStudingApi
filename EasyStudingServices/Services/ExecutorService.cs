using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request. In this service you need currentUserId to check permissons and create/close orders, role of user not contains in identity.
    public class ExecutorService: IExecutorService
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
        private readonly IRepository<Subscription> SubscriptionRepository;
        private readonly IRepository<UserDescription> UserDescriptionRepository;
        private readonly IRepository<UserInformation> UserInformationRepository;
        private readonly IRepository<UserPicture> UserPictureRepository;
        private readonly IRepository<UserRegistration> UserRegistrationRepository;
        private readonly IRepository<ValidationEmail> ValidationEmailRepository;
        private readonly IRepository<ValidationUser> ValidationUserRepository;
        private readonly IRepository<CloseTransaction> CloseTransactionRepository;
        private readonly IRepository<OpenTransaction> OpenTransactionRepository;

        public ExecutorService(
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
        IRepository<Subscription> SubscriptionRepository,
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
            this.SubscriptionRepository = SubscriptionRepository;
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
        ///   Get orders, classified by CustomerEducation and CustomerCity. 
        ///   If orders have executor, then not return them.
        /// </summary>
        /// <param name="education">Education of customer.</param>
        /// <param name="city">City of customer.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Orders sorted by city and education.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When education or city not found.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels(ApiEducationModel education, City city, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get order by id.
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Id of executor != currentUserId or current user not executor.</exception>

        public async Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Open transaction to get rights to perform order.
        /// </summary>
        /// <param name="id">Id of order to get rights for this order.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.InvalidOperationException">When order have executor.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<ApiOrderDetailsModel> GetTheRightsToPerformOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Close execute of order from Executor.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///   Requested order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<ApiOrderDetailsModel> CloseOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add skill to executor profile.
        /// </summary>
        /// <param name="id">Id of skill what executor want to add.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Added skill.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<Skill> AddSkill(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Romove skill from executor profile.
        /// </summary>
        /// <param name="id">Id of skill what executor want to remove.</param>
        /// <param name="currentUserId">Id of user who request data.</param>
        /// <returns>
        ///    Removed skill.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Current user not executor.</exception>

        public async Task<Skill> RemoveSkill(long id, long currentUserId)
        {
            throw new Exception();
        }
    }
}

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
    //currentUserId - current user, who send request.
    public class UserService: IUserService
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

        public UserService(
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
        ///   Get users, classified by education and city. 
        /// </summary>
        /// <param name="education">Education of user.</param>
        /// <param name="city">City of user.</param>
        /// <returns>
        ///    Users sorted by city and education.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When education or city not found.</exception>

        public async Task<IQueryable<ApiUserDescriptionModel>> GetApiUserDescriptionModels(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get information about user. 
        /// </summary>
        /// <param name="id">Id of user to return.</param>
        /// <returns>
        ///    Requsted user.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user not found.</exception>

        public async Task<ApiUserDescriptionModel> GetApiUserDescriptionModel(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get orders of current user. 
        /// </summary>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Orders.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.UnauthorizedAccessException">When user not found.</exception>

        public async Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels(long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get order of current user by id. 
        /// </summary>
        /// <param name="id">Id of current user order.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When order not found.</exception>
        /// <exception cref="System.UnauthorizedAccessException">When user not found or Customer of order != current user.</exception>

        public async Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get executors. 
        /// </summary>
        /// <param name="education">Education of executore.</param>
        /// <param name="city">City of executor.</param>
        /// <returns>
        ///    Executors.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When education or city not found.</exception>

        public async Task<IQueryable<ApiUserDescriptionModel>> GetSubscriptionExecutors(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Change password of current user. 
        /// </summary>
        /// <param name="oldPassword">Old password of user.</param>
        /// <param name="newPassword">New password of user.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    true - password changed, false - oldpassword incorrect
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user not found.</exception>

        public async Task<bool> ChangePassword(string oldPassword, string newPassword, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Change description of user. 
        /// </summary>
        /// <param name="description">Description model of user.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Changed model of current user.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user not found.</exception>
        /// <exception cref="System.InvalidOperationException">When user id of description != current user id.</exception>

        public async Task<ApiUserDescriptionModel> EditProfile(ApiUserDescriptionModel description, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add picture of user profile. 
        /// </summary>
        /// <param name="file">Picture to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added image.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user not found.</exception>

        public async Task<ApiFileToReturnModel> AddPictureProfile(ApiFileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Edit picture of user profile. 
        /// </summary>
        /// <param name="file">Picture to edit.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Edited image.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user not found.</exception>

        public async Task<ApiFileToReturnModel> EditPictureProfile(ApiFileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove picture of user profile. 
        /// </summary>
        /// <param name="id">Id of picture to remove.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Removed image.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user or picture not found.</exception>

        public async Task<ApiFileToReturnModel> RemovePictureProfile(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add request to buy subscription(executor/opensource validate by cost). 
        /// </summary>
        /// <param name="cost">Cost of subscription.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Cost of subscription.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user not found.</exception>

        public async Task<Cost> RequestToBuySubscription(Cost cost, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Close to buy subscription(executor/opensource validate by cost) and add subscription to user. 
        /// </summary>
        /// <param name="cost">Cost of subscription.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Cost of subscription.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user not found.</exception>

        public async Task<Cost> CompleteBuySubcription(Cost cost, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add file to open source area of user. 
        /// </summary>
        /// <param name="file">File to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added file.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user not found.</exception>

        public async Task<ApiFileToReturnModel> AddFileToOpenSource(ApiFileToAddModel file, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove file to open source area of user. 
        /// </summary>
        /// <param name="file">File to remove.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Removed file.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user or file not found.</exception>

        public async Task<ApiFileToReturnModel> RemoveFileFromOpenSource(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add order to area. 
        /// </summary>
        /// <param name="file">Order to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added order.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user not found.</exception>

        public async Task<ApiOrderDetailsModel> AddOrder(ApiOrderDetailsModel order, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add executor to order. 
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <param name="executorUserId">Id of executor.</param>
        /// <returns>
        ///    Updated order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When one of users or order not found.</exception>

        public async Task<ApiOrderDetailsModel> StartExecuteOrder(long id, long currentUserId, long executorUserId)
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
        /// <exception cref="System.IndexOutOfRangeException">When result or user not found.</exception>

        public async Task<ApiOrderDetailsModel> CloseOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add review to executor. 
        /// </summary>
        /// <param name="review">Review to add.</param>
        /// <param name="currentUserId">Id of current user.</param>
        /// <returns>
        ///    Added review.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When user or order not found.</exception>

        public async Task<ApiReviewModel> AddReview(ApiReviewModel review, long currentUserId)
        {
            throw new Exception();
        }
    }
}

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
    //In this service you don't need currentUserId to check permissons, role of user contains in identity.
    public class ModeratorService: IModeratorService
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

        public ModeratorService(
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
        ///   Restrict access to data.
        /// </summary>
        /// <param name="id">Id of user to ban.</param>
        /// <returns>
        ///    Banned user.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<ApiUserDescriptionModel> BanUser(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Give access to data.
        /// </summary>
        /// <param name="id">Id of user to remove ban.</param>
        /// <returns>
        ///    Unbanned user.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<ApiUserDescriptionModel> RemoveBanOfUser(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Close order.
        /// </summary>
        /// <param name="id">Id of order to close.</param>
        /// <returns>
        ///    Closed order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<ApiOrderDetailsModel> CloseOrder(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get orders, classified by CustomerEducation and CustomerCity. 
        /// </summary>
        /// <param name="education">Education of customer.</param>
        /// <param name="city">City of customer.</param>
        /// <returns>
        ///    Orders sorted by city and education.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When education or city not found.</exception>

        public async Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Get order by id.
        /// </summary>
        /// <param name="id">Id of order.</param>
        /// <returns>
        ///    Requsted order.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>
        /// <exception cref="System.IndexOutOfRangeException">When result not found.</exception>

        public async Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add country.
        /// </summary>
        /// <param name="country">Country to add.</param>
        /// <returns>
        ///    Added country.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>

        public async Task<Country> AddCountry(Country country)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Edit country.
        /// </summary>
        /// <param name="country">Country to edit.</param>
        /// <returns>
        ///    Edited country.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Country> EditCountry(Country country)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove country.
        /// </summary>
        /// <param name="id">Id of country to remove.</param>
        /// <returns>
        ///    Removed country.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Country> RemoveCountry(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add city.
        /// </summary>
        /// <param name="city">City to add.</param>
        /// <returns>
        ///    Added city.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>

        public async Task<City> AddCity(City city)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Edit city.
        /// </summary>
        /// <param name="city">City to edit.</param>
        /// <returns>
        ///    Edited city.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<City> EditCity(City city)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove city.
        /// </summary>
        /// <param name="id">Id of city to remove.</param>
        /// <returns>
        ///    Removed city.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<City> RemoveCity(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add education type.
        /// </summary>
        /// <param name="educationType">Education type to add.</param>
        /// <returns>
        ///    Added education type.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>

        public async Task<EducationType> AddEducationType(EducationType educationType)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Edit education type.
        /// </summary>
        /// <param name="educationType">Education type to edit.</param>
        /// <returns>
        ///    Edited education type.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<EducationType> EditEducationtype(EducationType educationType)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove education type.
        /// </summary>
        /// <param name="id">Id of education type to remove.</param>
        /// <returns>
        ///    Removed education type.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<EducationType> RemoveEducationType(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add education.
        /// </summary>
        /// <param name="education">Education to add.</param>
        /// <returns>
        ///    Added education.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>

        public async Task<ApiEducationModel> AddEducation(ApiEducationModel education)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Edit education.
        /// </summary>
        /// <param name="education">Education to edit.</param>
        /// <returns>
        ///    Edited education.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<ApiEducationModel> EditEducation(ApiEducationModel education)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove education.
        /// </summary>
        /// <param name="id">Id of education to remove.</param>
        /// <returns>
        ///    Removed education.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<ApiEducationModel> RemoveEducation(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add cost.
        /// </summary>
        /// <param name="cost">Cost to add.</param>
        /// <returns>
        ///    Added cost.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>

        public async Task<Cost> AddCost(Cost cost)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Edit cost.
        /// </summary>
        /// <param name="cost">Cost to edit.</param>
        /// <returns>
        ///    Edited cost.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Cost> EditCost(Cost cost)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove cost.
        /// </summary>
        /// <param name="id">Id of cost to remove.</param>
        /// <returns>
        ///    Removed cost.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Cost> RemoveCost(long id)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Add skill.
        /// </summary>
        /// <param name="skill">Skill to add.</param>
        /// <returns>
        ///    Added skill.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>

        public async Task<Skill> AddSkill(Skill skill)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Edit skill.
        /// </summary>
        /// <param name="skill">Skill to edit.</param>
        /// <returns>
        ///    Edited skill.
        /// </returns>
        /// <exception cref="System.FormatException">When one of params invalid.</exception>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Skill> EditSkill(Skill skill)
        {
            throw new Exception();
        }

        /// <summary>
        ///   Remove skill.
        /// </summary>
        /// <param name="id">Id of skill to remove.</param>
        /// <returns>
        ///    Removed skill.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">When result null.</exception>

        public async Task<Skill> RemoveSkill(long id)
        {
            throw new Exception();
        }

    }
}

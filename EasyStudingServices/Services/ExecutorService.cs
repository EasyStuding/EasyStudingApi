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
        private readonly IRepository<Education> EducationRepository;
        private readonly IRepository<EducationType> EducationTypeRepository;
        private readonly IRepository<City> CityRepository;
        private readonly IRepository<Country> CountryRepository;
        private readonly IRepository<UserRegistration> UserRegistrationRepository;
        private readonly IRepository<UserInformation> UserInformationRepository;
        private readonly IRepository<UserDescription> UserDescriptionRepository;
        private readonly IRepository<OrderDetails> OrderDetailsRepository;
        private readonly IRepository<State> StateRepository;
        private readonly IRepository<Skill> SkillRepository;
        private readonly IRepository<Attachment> AttachmentRepository;
        private readonly IRepository<OpenTransaction> OpenTransactionRepository;
        private readonly IRepository<CloseTransaction> CloseTransactionRepository;

        public ExecutorService(IRepository<Education> educationRepository,
            IRepository<EducationType> educationTypeRepository,
            IRepository<City> cityRepository,
            IRepository<Country> coutryRepository,
            IRepository<UserRegistration> userRegistrationRepository,
            IRepository<UserInformation> userInformationRepository,
            IRepository<UserDescription> userDescriptionRepository,
            IRepository<OrderDetails> orderDetailsRepository,
            IRepository<State> stateRepository,
            IRepository<Skill> skillRepository,
            IRepository<Attachment> attachmentRepository,
            IRepository<OpenTransaction> openTransactionRepository,
            IRepository<CloseTransaction> closeTransactionRepository)
        {
            EducationRepository = educationRepository;
            EducationTypeRepository = educationTypeRepository;
            CityRepository = cityRepository;
            CountryRepository = coutryRepository;
            UserRegistrationRepository = userRegistrationRepository;
            UserInformationRepository = userInformationRepository;
            UserDescriptionRepository = userDescriptionRepository;
            OrderDetailsRepository = orderDetailsRepository;
            StateRepository = stateRepository;
            SkillRepository = skillRepository;
            AttachmentRepository = attachmentRepository;
            OpenTransactionRepository = openTransactionRepository;
            CloseTransactionRepository = closeTransactionRepository;
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

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
        private readonly IRepository<UserPicture> UserPictureRepository;
        private readonly IRepository<UserRegistration> UserRegistrationRepository;
        private readonly IRepository<UserInformation> UserInformationRepository;
        private readonly IRepository<UserDescription> UserDescriptionRepository;
        private readonly IRepository<OrderDetails> OrderDetailsRepository;
        private readonly IRepository<Attachment> AttachmentRepository;
        private readonly IRepository<State> StateRepository;
        private readonly IRepository<Skill> SkillRepository;
        private readonly IRepository<Cost> CostRepository;
        private readonly IRepository<Education> EducationRepository;
        private readonly IRepository<EducationType> EducationTypeRepository;
        private readonly IRepository<City> CityRepository;
        private readonly IRepository<Country> CountryRepository;
        private readonly IRepository<Role> RoleRepository;

        public ModeratorService(IRepository<Education> educationRepository,
            IRepository<EducationType> educationTypeRepository,
            IRepository<City> cityRepository,
            IRepository<Country> coutryRepository,
            IRepository<Role> roleRepository,
            IRepository<UserPicture> userPictureRepository,
            IRepository<UserRegistration> userRegistrationRepository,
            IRepository<UserInformation> userInformationRepository,
            IRepository<UserDescription> userDescriptionRepository,
            IRepository<OrderDetails> orderDetailsRepository,
            IRepository<State> stateRepository,
            IRepository<Skill> skillRepository,
            IRepository<Cost> costRepository,
            IRepository<Attachment> attachmentRepository)
        {
            EducationRepository = educationRepository;
            EducationTypeRepository = educationTypeRepository;
            CityRepository = cityRepository;
            CountryRepository = coutryRepository;
            RoleRepository = roleRepository;
            UserPictureRepository = userPictureRepository;
            UserRegistrationRepository = userRegistrationRepository;
            UserInformationRepository = userInformationRepository;
            UserDescriptionRepository = userDescriptionRepository;
            OrderDetailsRepository = orderDetailsRepository;
            StateRepository = stateRepository;
            SkillRepository = skillRepository;
            CostRepository = costRepository;
            AttachmentRepository = attachmentRepository;
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

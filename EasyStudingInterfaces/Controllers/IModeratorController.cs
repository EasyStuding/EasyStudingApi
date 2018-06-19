using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IModeratorController
    {
        Task<ApiUserDescriptionModel> BanUser(long id);

        Task<ApiUserDescriptionModel> RemoveBanOfUser(long id);

        Task<ApiOrderDetailsModel> CloseOrder(long id);

        Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels(ApiEducationModel education, City city);

        Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id);

        Task<Country> AddCountry(Country country);
        Task<Country> EditCountry(Country country);
        Task<Country> RemoveCountry(long id);

        Task<City> AddCity(City city);
        Task<City> EditCity(City city);
        Task<City> RemoveCity(long id);

        Task<EducationType> AddEducationType(EducationType educationType);
        Task<EducationType> EditEducationtype(EducationType educationType);
        Task<EducationType> RemoveEducationType(long id);

        Task<ApiEducationModel> AddEducation(ApiEducationModel education);
        Task<ApiEducationModel> EditEducation(ApiEducationModel education);
        Task<ApiEducationModel> RemoveEducation(long id);

        Task<Cost> AddCost(Cost cost);
        Task<Cost> EditCost(Cost cost);
        Task<Cost> RemoveCost(long id);

        Task<Skill> AddSkill(Skill skill);
        Task<Skill> EditSkill(Skill skill);
        Task<Skill> RemoveSkill(long id);
    }
}

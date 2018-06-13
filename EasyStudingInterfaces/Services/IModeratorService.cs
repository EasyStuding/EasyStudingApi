using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System.Linq;

namespace EasyStudingInterfaces.Services
{
    public interface IModeratorService
    {
        ApiUserInformationModel BanUser(long id);

        ApiUserInformationModel RemoveBanOfUser(long id);

        ApiOrderDetailsModel CloseOrder(long id);

        IQueryable<ApiOrderDetailsModel> GetApiOrderDetailsModels(ApiEducationModel education, City city);

        ApiOrderDetailsModel GetApiOrderDetailsModel(long id);

        Country AddCountry(Country country);
        Country EditCountry(Country country);
        Country RemoveCountry(long id);

        City AddCity(City city);
        City EditCity(City city);
        City RemoveCity(long id);

        EducationType AddEducationType(EducationType educationType);
        EducationType EditEducationtype(EducationType educationType);
        EducationType RemoveEducationType(long id);

        ApiEducationModel AddEducation(ApiEducationModel education);
        ApiEducationModel EditEducation(ApiEducationModel education);
        ApiEducationModel Removeeducation(long id);

        Cost AddCost(Cost cost);
        Cost EditCost(Cost cost);
        Cost RemoveCost(long id);

        Skill AddSkill(Skill skill);
        Skill EditSkill(Skill skill);
        Skill RemoveSkill(long id);
    }
}

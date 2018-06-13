using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface IConstantEntityController
    {
        Country AddCountry(Country country);
        Country EditCountry(Country country);
        Country RemoveCountry(long id);

        City AddCity(City city);
        City EditCity(City city);
        City RemoveCity(long id);

        EducationType AddEducationType(EducationType educationType);
        EducationType EditEducationtype(EducationType educationType);
        EducationType RemoveEducationType(long id);

        ApiEducation AddEducation(ApiEducation education);
        ApiEducation EditEducation(ApiEducation education);
        ApiEducation Removeeducation(long id);

        Cost AddCost(Cost cost);
        Cost EditCost(Cost cost);
        Cost RemoveCost(long id);

        Skill AddSkill(Skill skill);
        Skill EditSkill(Skill skill);
        Skill RemoveSkill(long id);
    }
}

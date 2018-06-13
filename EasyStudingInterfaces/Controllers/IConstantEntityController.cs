using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingInterfaces.Controllers
{
    public interface IConstantEntityController
    {
        bool AddCountry(Country country);
        bool EditCountry(Country country);
        bool RemoveCountry(long id);

        bool AddCity(City city);
        bool EditCity(City city);
        bool RemoveCity(long id);

        bool AddEducationType(EducationType educationType);
        bool EditEducationtype(EducationType educationType);
        bool RemoveEducationType(long id);

        bool AddEducation(ApiEducation education);
        bool EditEducation(ApiEducation education);
        bool Removeeducation(long id);

        bool AddCost(Cost cost);
        bool EditCost(Cost cost);
        bool RemoveCost(long id);

        bool AddSkill(Skill skill);
        bool EditSkill(Skill skill);
        bool RemoveSkill(long id);
    }
}

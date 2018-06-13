using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyStudingServices.Services
{
    public class ModeratorService: IModeratorService
    {
        //TODO: initialize repositories;

        public ApiUserInformationModel BanUser(long id)
        {
            throw new Exception();
        }

        public ApiUserInformationModel RemoveBanOfUser(long id)
        {
            throw new Exception();
        }

        public ApiOrderDetailsModel CloseOrder(long id)
        {
            throw new Exception();
        }

        public IQueryable<ApiOrderDetailsModel> GetApiOrderDetailsModels(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        public ApiOrderDetailsModel GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        public Country AddCountry(Country country)
        {
            throw new Exception();
        }

        public Country EditCountry(Country country)
        {
            throw new Exception();
        }

        public Country RemoveCountry(long id)
        {
            throw new Exception();
        }

        public City AddCity(City city)
        {
            throw new Exception();
        }

        public City EditCity(City city)
        {
            throw new Exception();
        }

        public City RemoveCity(long id)
        {
            throw new Exception();
        }

        public EducationType AddEducationType(EducationType educationType)
        {
            throw new Exception();
        }

        public EducationType EditEducationtype(EducationType educationType)
        {
            throw new Exception();
        }

        public EducationType RemoveEducationType(long id)
        {
            throw new Exception();
        }

        public ApiEducationModel AddEducation(ApiEducationModel education)
        {
            throw new Exception();
        }

        public ApiEducationModel EditEducation(ApiEducationModel education)
        {
            throw new Exception();
        }

        public ApiEducationModel RemoveEducation(long id)
        {
            throw new Exception();
        }

        public Cost AddCost(Cost cost)
        {
            throw new Exception();
        }

        public Cost EditCost(Cost cost)
        {
            throw new Exception();
        }

        public Cost RemoveCost(long id)
        {
            throw new Exception();
        }

        public Skill AddSkill(Skill skill)
        {
            throw new Exception();
        }

        public Skill EditSkill(Skill skill)
        {
            throw new Exception();
        }

        public Skill RemoveSkill(long id)
        {
            throw new Exception();
        }

    }
}

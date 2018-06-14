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
    public class ModeratorService: IModeratorService
    {
        //TODO: initialize repositories;

        public async Task<ApiUserInformationModel> BanUser(long id)
        {
            throw new Exception();
        }

        public async Task<ApiUserInformationModel> RemoveBanOfUser(long id)
        {
            throw new Exception();
        }

        public async Task<ApiOrderDetailsModel> CloseOrder(long id)
        {
            throw new Exception();
        }

        public async Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        public async Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        public async Task<Country> AddCountry(Country country)
        {
            throw new Exception();
        }

        public async Task<Country> EditCountry(Country country)
        {
            throw new Exception();
        }

        public async Task<Country> RemoveCountry(long id)
        {
            throw new Exception();
        }

        public async Task<City> AddCity(City city)
        {
            throw new Exception();
        }

        public async Task<City> EditCity(City city)
        {
            throw new Exception();
        }

        public async Task<City> RemoveCity(long id)
        {
            throw new Exception();
        }

        public async Task<EducationType> AddEducationType(EducationType educationType)
        {
            throw new Exception();
        }

        public async Task<EducationType> EditEducationtype(EducationType educationType)
        {
            throw new Exception();
        }

        public async Task<EducationType> RemoveEducationType(long id)
        {
            throw new Exception();
        }

        public async Task<ApiEducationModel> AddEducation(ApiEducationModel education)
        {
            throw new Exception();
        }

        public async Task<ApiEducationModel> EditEducation(ApiEducationModel education)
        {
            throw new Exception();
        }

        public async Task<ApiEducationModel> RemoveEducation(long id)
        {
            throw new Exception();
        }

        public async Task<Cost> AddCost(Cost cost)
        {
            throw new Exception();
        }

        public async Task<Cost> EditCost(Cost cost)
        {
            throw new Exception();
        }

        public async Task<Cost> RemoveCost(long id)
        {
            throw new Exception();
        }

        public async Task<Skill> AddSkill(Skill skill)
        {
            throw new Exception();
        }

        public async Task<Skill> EditSkill(Skill skill)
        {
            throw new Exception();
        }

        public async Task<Skill> RemoveSkill(long id)
        {
            throw new Exception();
        }

    }
}

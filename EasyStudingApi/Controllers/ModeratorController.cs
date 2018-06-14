using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;

namespace EasyStudingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Moderator/[action]")]
    public class ModeratorController : Controller, IModeratorController
    {
        private readonly IModeratorService Service;

        public ModeratorController(IModeratorService service)
        {
            Service = service;
        }

        [HttpPost]
        // * - host.
        // */api/moderator/BanUser
        public async Task<ApiUserInformationModel> BanUser(long id)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveBanOfUser
        public async Task<ApiUserInformationModel> RemoveBanOfUser(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/CloseOrder
        public async Task<ApiOrderDetailsModel> CloseOrder(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/moderator/GetApiOrderDetailsModels
        public async Task<IQueryable<ApiOrderDetailsModel>> GetApiOrderDetailsModels([FromBody]ApiEducationModel education, [FromBody]City city)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/moderator/GetApiOrderDetailsModel
        public async Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddCountry
        public async Task<Country> AddCountry([FromBody]Country country)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditCountry
        public async Task<Country> EditCountry([FromBody]Country country)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveCountry
        public async Task<Country> RemoveCountry(long id)

        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddCity
        public async Task<City> AddCity([FromBody]City city)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditCity
        public async Task<City> EditCity([FromBody]City city)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveCity
        public async Task<City> RemoveCity(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddEducationType
        public async Task<EducationType> AddEducationType([FromBody]EducationType educationType)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditEducationtype
        public async Task<EducationType> EditEducationtype([FromBody]EducationType educationType)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveEducationType
        public async Task<EducationType> RemoveEducationType(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddEducation
        public async Task<ApiEducationModel> AddEducation([FromBody]ApiEducationModel education)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditEducation
        public async Task<ApiEducationModel> EditEducation([FromBody]ApiEducationModel education)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveEducation
        public async Task<ApiEducationModel> RemoveEducation(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddCost
        public async Task<Cost> AddCost([FromBody]Cost cost)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditCost
        public async Task<Cost> EditCost([FromBody]Cost cost)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveCost
        public async Task<Cost> RemoveCost(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddSkill
        public async Task<Skill> AddSkill([FromBody]Skill skill)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditSkill
        public async Task<Skill> EditSkill([FromBody]Skill skill)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveSkill
        public async Task<Skill> RemoveSkill(long id)
        {
            throw new Exception();
        }
    }
}
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
        public ApiUserInformationModel BanUser(long id)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveBanOfUser
        public ApiUserInformationModel RemoveBanOfUser(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/CloseOrder
        public ApiOrderDetailsModel CloseOrder(long id)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/moderator/GetApiOrderDetailsModels
        public IQueryable<ApiOrderDetailsModel> GetApiOrderDetailsModels([FromBody]ApiEducationModel education, [FromBody]City city)
        {
            throw new Exception();
        }

        [HttpGet]
        // */api/moderator/GetApiOrderDetailsModel
        public ApiOrderDetailsModel GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddCountry
        public Country AddCountry([FromBody]Country country)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditCountry
        public Country EditCountry([FromBody]Country country)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveCountry
        public Country RemoveCountry(long id)

        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddCity
        public City AddCity([FromBody]City city)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditCity
        public City EditCity([FromBody]City city)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveCity
        public City RemoveCity(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddEducationType
        public EducationType AddEducationType([FromBody]EducationType educationType)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditEducationtype
        public EducationType EditEducationtype([FromBody]EducationType educationType)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveEducationType
        public EducationType RemoveEducationType(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddEducation
        public ApiEducationModel AddEducation([FromBody]ApiEducationModel education)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditEducation
        public ApiEducationModel EditEducation([FromBody]ApiEducationModel education)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveEducation
        public ApiEducationModel RemoveEducation(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddCost
        public Cost AddCost([FromBody]Cost cost)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditCost
        public Cost EditCost([FromBody]Cost cost)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveCost
        public Cost RemoveCost(long id)
        {
            throw new Exception();
        }

        [HttpPost]
        // */api/moderator/AddSkill
        public Skill AddSkill([FromBody]Skill skill)
        {
            throw new Exception();
        }

        [HttpPut]
        // */api/moderator/EditSkill
        public Skill EditSkill([FromBody]Skill skill)
        {
            throw new Exception();
        }

        [HttpDelete]
        // */api/moderator/RemoveSkill
        public Skill RemoveSkill(long id)
        {
            throw new Exception();
        }
    }
}
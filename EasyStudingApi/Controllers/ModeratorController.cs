using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.Models;

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
        // /api/moderator/BanUser
        public async Task<User> BanUser(long id)
        {
            throw new Exception();
        }

        // /api/moderator/RemoveBanOfUser
        public async Task<User> RemoveBanOfUser(long id)
        {
            throw new Exception();
        }

        // /api/moderator/CloseOrder
        public async Task<Order> CloseOrder(long id)
        {
            throw new Exception();
        }

        // /api/moderator/GetOrders
        public async Task<IQueryable<Order>> GetOrders(string education, string country, string city)
        {
            throw new Exception();
        }

        // /api/moderator/GetOrder
        public async Task<Order> GetOrder(long id)
        {
            throw new Exception();
        }

        // /api/moderator/AddCountry
        public async Task<Country> AddCountry(Country country)
        {
            throw new Exception();
        }

        // /api/moderator/EditCountry
        public async Task<Country> EditCountry(Country country)
        {
            throw new Exception();
        }

        // /api/moderator/RemoveCountry
        public async Task<Country> RemoveCountry(long id)
        {
            throw new Exception();
        }

        // /api/moderator/AddCity
        public async Task<City> AddCity(City city)
        {
            throw new Exception();
        }

        // /api/moderator/EditCity
        public async Task<City> EditCity(City city)
        {
            throw new Exception();
        }

        // /api/moderator/RemoveCity
        public async Task<City> RemoveCity(long id)
        {
            throw new Exception();
        }

        // /api/moderator/AddSkill
        public async Task<Skill> AddSkill(Skill skill)
        {
            throw new Exception();
        }

        // /api/moderator/EditSkill
        public async Task<Skill> EditSkill(Skill skill)
        {
            throw new Exception();
        }

        // /api/moderator/RemoveSkill
        public async Task<Skill> RemoveSkill(long id)
        {
            throw new Exception();
        }
    }
}
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.Models;
using Microsoft.AspNetCore.Authorization;

namespace EasyStudingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Location/[action]")]
    [Authorize]
    public class LocationController : Controller, ILocationController
    {
        private readonly ILocationService _service;

        public LocationController(ILocationService service)
        {
            _service = service;
        }

        [HttpGet]
        // /api/location/GetCountries
        public IQueryable<Country> GetCountries()
        {
            return _service.GetCountries();
        }

        [HttpGet]
        // /api/location/GetRegions
        public IQueryable<Region> GetRegions(long countryId)
        {
            return _service.GetRegions(countryId);
        }

        [HttpGet]
        // /api/location/GetCities
        public IQueryable<City> GetCities(long regionId)
        {
            return _service.GetCities(regionId);
        }

        [HttpGet]
        // /api/location/GetCountry
        public async Task<Country> GetCountry(long id)
        {
            return await _service.GetCountry(id);
        }

        [HttpGet]
        // /api/location/GetRegion
        public async Task<Region> GetRegion(long id)
        {
            return await _service.GetRegion(id);
        }

        [HttpGet]
        // /api/location/GetCity
        public async Task<City> GetCity(long id)
        {
            return await _service.GetCity(id);
        }
    }
}
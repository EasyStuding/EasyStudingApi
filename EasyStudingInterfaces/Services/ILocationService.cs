﻿using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Services
{
    public interface ILocationService
    {
        IQueryable<Country> GetCountries();
        IQueryable<Region> GetRegions(long countryId);
        IQueryable<City> GetCities(long regionId);

        Task<Country> GetCountry(long id);
        Task<Region> GetRegion(long id);
        Task<City> GetCity(long id);
    }
}
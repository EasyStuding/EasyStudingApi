﻿using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EasyStudingInterfaces.Services;

namespace EasyStudingRepositories.Repositories
{
    public class CityRepository : IRepository<City>
    {
        private readonly EasyStudingContext context;
        private readonly IErrorHandler _errorHandler;

        public CityRepository(EasyStudingContext context, IErrorHandler errorHandler)
        {
            this.context = context;
            _errorHandler = errorHandler;
        }

        public IQueryable<City> GetAll()
        {
            return context.Cities;
        }

        public async Task<City> GetAsync(long id)
        {
            var cityModel = await context.Cities.FirstOrDefaultAsync(city => city.Id == id);

            _errorHandler.CheckIndexOutOfRangeException(cityModel);

            return cityModel;
        }

        public async Task<City> AddAsync(City city)
        {
            _errorHandler.CheckObjectOfNull(city);

            await context.Cities.AddAsync(city);

            await context.SaveChangesAsync();

            return context.Cities.LastOrDefault();
        }

        public async Task<City> EditAsync(City cityModel)
        {
            _errorHandler.CheckObjectOfNull(cityModel);

            var city = await GetAsync(cityModel.Id);


            city.Name = cityModel.Name;
            city.CountryId = cityModel.CountryId;
            city.Region = cityModel.Region;

            await context.SaveChangesAsync();

            return city;
        }

        public async Task<City> RemoveAsync(long id)
        {
            var city = await GetAsync(id);

            context.Cities.Remove(city);

            await context.SaveChangesAsync();

            return city;
        }
    }
}

using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData.Repositories
{
    public class CityRepository: IRepository<City>
    {
        private readonly EasyStudingContext Context;

        public CityRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<City> GetAll()
        {
            return Context.Cities;
        }

        public async Task<City> GetAsync(long id)
        {
            return await Context.Cities.FindAsync(id);
        }

        public async Task<City> AddAsync(City param)
        {
            await Context.Cities.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.Cities.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<City> EditAsync(City param)
        {
            var model = await Context.Cities.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<City> RemoveAsync(long id)
        {
            var model = await Context.Cities.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.Cities.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

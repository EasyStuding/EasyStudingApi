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
    public class CountryRepository: IRepository<Country>
    {
        private readonly EasyStudingContext Context;

        public CountryRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Country> GetAll()
        {
            return Context.Countries;
        }

        public async Task<Country> Get(long id)
        {
            return await Context.Countries.FindAsync(id);
        }

        public async Task<Country> Add(Country param)
        {
            await Context.Countries.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.Countries.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<Country> Edit(Country param)
        {
            var model = await Context.Countries.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<Country> Remove(long id)
        {
            var model = await Context.Countries.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.Countries.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

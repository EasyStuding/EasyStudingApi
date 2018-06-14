using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingRepositories.Repositories
{
    public class CountryRepository: IRepository<Country>
    {
        private readonly EasyStudingContext Context;

        public CountryRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public async Task<IQueryable<Country>> GetAll()
        {
            throw new Exception();
        }

        public async Task<Country> Get(long id)
        {
            throw new Exception();
        }

        public async Task<Country> Add(Country param)
        {
            throw new Exception();
        }

        public async Task<Country> Edit(Country param)
        {
            throw new Exception();
        }

        public async Task<Country> Remove(Country param)
        {
            throw new Exception();
        }
    }
}

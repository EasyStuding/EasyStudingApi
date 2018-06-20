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

        public IQueryable<Country> GetAll()
        {
            throw new Exception();
        }

        public async Task<Country> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<Country> AddAsync(Country param)
        {
            throw new Exception();
        }

        public async Task<Country> EditAsync(Country param)
        {
            throw new Exception();
        }

        public async Task<Country> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

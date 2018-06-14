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
    public class CityRepository: IRepository<City>
    {
        private readonly EasyStudingContext Context;

        public CityRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public async Task<IQueryable<City>> GetAll()
        {
            throw new Exception();
        }

        public async Task<City> Get(long id)
        {
            throw new Exception();
        }

        public async Task<City> Add(City param)
        {
            throw new Exception();
        }

        public async Task<City> Edit(City param)
        {
            throw new Exception();
        }

        public async Task<City> Remove(City param)
        {
            throw new Exception();
        }
    }
}

using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public Country Get(long id)
        {
            throw new Exception();
        }

        public Country Add(Country param)
        {
            throw new Exception();
        }

        public Country Edit(Country param)
        {
            throw new Exception();
        }

        public Country Remove(Country param)
        {
            throw new Exception();
        }
    }
}

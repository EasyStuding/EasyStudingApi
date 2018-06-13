using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyStudingRepositories.Repositories
{
    public class CostRepository: IRepository<Cost>
    {
        private readonly EasyStudingContext Context;

        public CostRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Cost> GetAll()
        {
            throw new Exception();
        }

        public Cost Get(long id)
        {
            throw new Exception();
        }

        public Cost Add(Cost param)
        {
            throw new Exception();
        }

        public Cost Edit(Cost param)
        {
            throw new Exception();
        }

        public Cost Remove(Cost param)
        {
            throw new Exception();
        }
    }
}

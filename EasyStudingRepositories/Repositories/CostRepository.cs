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

        public async Task<Cost> Get(long id)
        {
            throw new Exception();
        }

        public async Task<Cost> Add(Cost param)
        {
            throw new Exception();
        }

        public async Task<Cost> Edit(Cost param)
        {
            throw new Exception();
        }

        public async Task<Cost> Remove(Cost param)
        {
            throw new Exception();
        }
    }
}

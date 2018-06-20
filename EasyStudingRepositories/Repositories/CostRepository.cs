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

        public async Task<Cost> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<Cost> AddAsync(Cost param)
        {
            throw new Exception();
        }

        public async Task<Cost> EditAsync(Cost param)
        {
            throw new Exception();
        }

        public async Task<Cost> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

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
    public class CostRepository: IRepository<Cost>
    {
        private readonly EasyStudingContext Context;

        public CostRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Cost> GetAll()
        {
            return Context.Costs;
        }

        public async Task<Cost> Get(long id)
        {
            return await Context.Costs.FindAsync(id);
        }

        public async Task<Cost> Add(Cost param)
        {
            await Context.Costs.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.Costs.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<Cost> Edit(Cost param)
        {
            var model = await Context.Costs.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<Cost> Remove(long id)
        {
            var model = await Context.Costs.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.Costs.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

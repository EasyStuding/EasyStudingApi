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
    public class SubscriptionOpenSourceRepository: IRepository<SubscriptionOpenSource>
    {
        private readonly EasyStudingContext Context;

        public SubscriptionOpenSourceRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<SubscriptionOpenSource> GetAll()
        {
            return Context.SubscriptionOpenSources;
        }

        public async Task<SubscriptionOpenSource> GetAsync(long id)
        {
            return await Context.SubscriptionOpenSources.FindAsync(id);
        }

        public async Task<SubscriptionOpenSource> AddAsync(SubscriptionOpenSource param)
        {
            await Context.SubscriptionOpenSources.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.SubscriptionOpenSources.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<SubscriptionOpenSource> EditAsync(SubscriptionOpenSource param)
        {
            var model = await Context.SubscriptionOpenSources.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<SubscriptionOpenSource> RemoveAsync(long id)
        {
            var model = await Context.SubscriptionOpenSources.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.SubscriptionOpenSources.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

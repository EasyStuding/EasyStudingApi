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
    public class SubscriptionRepository: IRepository<Subscription>
    {
        private readonly EasyStudingContext Context;

        public SubscriptionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Subscription> GetAll()
        {
            return Context.Subscriptions;
        }

        public async Task<Subscription> GetAsync(long id)
        {
            return await Context.Subscriptions.FindAsync(id);
        }

        public async Task<Subscription> AddAsync(Subscription param)
        {
            await Context.Subscriptions.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.Subscriptions.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<Subscription> EditAsync(Subscription param)
        {
            var model = await Context.Subscriptions.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<Subscription> RemoveAsync(long id)
        {
            var model = await Context.Subscriptions.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.Subscriptions.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

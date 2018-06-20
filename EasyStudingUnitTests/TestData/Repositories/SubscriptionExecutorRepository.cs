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
    public class SubscriptionExecutorRepository: IRepository<SubscriptionExecutor>
    {
        private readonly EasyStudingContext Context;

        public SubscriptionExecutorRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<SubscriptionExecutor> GetAll()
        {
            return Context.SubscriptionExecutors;
        }

        public async Task<SubscriptionExecutor> GetAsync(long id)
        {
            return await Context.SubscriptionExecutors.FindAsync(id);
        }

        public async Task<SubscriptionExecutor> AddAsync(SubscriptionExecutor param)
        {
            await Context.SubscriptionExecutors.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.SubscriptionExecutors.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<SubscriptionExecutor> EditAsync(SubscriptionExecutor param)
        {
            var model = await Context.SubscriptionExecutors.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<SubscriptionExecutor> RemoveAsync(long id)
        {
            var model = await Context.SubscriptionExecutors.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.SubscriptionExecutors.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

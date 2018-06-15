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
    public class SubscriptionExecutorRepository: IRepository<SubscriptionExecutor>
    {
        private readonly EasyStudingContext Context;

        public SubscriptionExecutorRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<SubscriptionExecutor> GetAll()
        {
            throw new Exception();
        }

        public async Task<SubscriptionExecutor> Get(long id)
        {
            throw new Exception();
        }

        public async Task<SubscriptionExecutor> Add(SubscriptionExecutor param)
        {
            throw new Exception();
        }

        public async Task<SubscriptionExecutor> Edit(SubscriptionExecutor param)
        {
            throw new Exception();
        }

        public async Task<SubscriptionExecutor> Remove(long id)
        {
            throw new Exception();
        }
    }
}

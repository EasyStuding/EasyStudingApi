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

        public async Task<SubscriptionExecutor> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<SubscriptionExecutor> AddAsync(SubscriptionExecutor param)
        {
            throw new Exception();
        }

        public async Task<SubscriptionExecutor> EditAsync(SubscriptionExecutor param)
        {
            throw new Exception();
        }

        public async Task<SubscriptionExecutor> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

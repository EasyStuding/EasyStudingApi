using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public SubscriptionExecutor Get(long id)
        {
            throw new Exception();
        }

        public SubscriptionExecutor Add(SubscriptionExecutor param)
        {
            throw new Exception();
        }

        public SubscriptionExecutor Edit(SubscriptionExecutor param)
        {
            throw new Exception();
        }

        public SubscriptionExecutor Remove(SubscriptionExecutor param)
        {
            throw new Exception();
        }
    }
}

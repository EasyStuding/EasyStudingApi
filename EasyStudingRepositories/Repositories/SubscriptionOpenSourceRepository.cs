using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyStudingRepositories.Repositories
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
            throw new Exception();
        }

        public SubscriptionOpenSource Get(long id)
        {
            throw new Exception();
        }

        public SubscriptionOpenSource Add(SubscriptionOpenSource param)
        {
            throw new Exception();
        }

        public SubscriptionOpenSource Edit(SubscriptionOpenSource param)
        {
            throw new Exception();
        }

        public SubscriptionOpenSource Remove(SubscriptionOpenSource param)
        {
            throw new Exception();
        }
    }
}

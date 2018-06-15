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

        public async Task<SubscriptionOpenSource> Get(long id)
        {
            throw new Exception();
        }

        public async Task<SubscriptionOpenSource> Add(SubscriptionOpenSource param)
        {
            throw new Exception();
        }

        public async Task<SubscriptionOpenSource> Edit(SubscriptionOpenSource param)
        {
            throw new Exception();
        }

        public async Task<SubscriptionOpenSource> Remove(long id)
        {
            throw new Exception();
        }
    }
}

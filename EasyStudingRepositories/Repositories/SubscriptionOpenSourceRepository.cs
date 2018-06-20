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

        public async Task<SubscriptionOpenSource> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<SubscriptionOpenSource> AddAsync(SubscriptionOpenSource param)
        {
            throw new Exception();
        }

        public async Task<SubscriptionOpenSource> EditAsync(SubscriptionOpenSource param)
        {
            throw new Exception();
        }

        public async Task<SubscriptionOpenSource> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

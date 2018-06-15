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
    public class OrderDetailsRepository: IRepository<OrderDetails>
    {
        private readonly EasyStudingContext Context;

        public OrderDetailsRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OrderDetails> GetAll()
        {
            throw new Exception();
        }

        public async Task<OrderDetails> Get(long id)
        {
            throw new Exception();
        }

        public async Task<OrderDetails> Add(OrderDetails param)
        {
            throw new Exception();
        }

        public async Task<OrderDetails> Edit(OrderDetails param)
        {
            throw new Exception();
        }

        public async Task<OrderDetails> Remove(OrderDetails param)
        {
            throw new Exception();
        }
    }
}

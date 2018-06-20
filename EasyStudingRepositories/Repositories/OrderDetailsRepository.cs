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

        public async Task<OrderDetails> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<OrderDetails> AddAsync(OrderDetails param)
        {
            throw new Exception();
        }

        public async Task<OrderDetails> EditAsync(OrderDetails param)
        {
            throw new Exception();
        }

        public async Task<OrderDetails> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

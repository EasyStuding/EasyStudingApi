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
    public class OrderDetailsRepository: IRepository<OrderDetails>
    {
        private readonly EasyStudingContext Context;

        public OrderDetailsRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OrderDetails> GetAll()
        {
            return Context.OrderDetails;
        }

        public async Task<OrderDetails> Get(long id)
        {
            return await Context.OrderDetails.FindAsync(id);
        }

        public async Task<OrderDetails> Add(OrderDetails param)
        {
            await Context.OrderDetails.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.OrderDetails.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<OrderDetails> Edit(OrderDetails param)
        {
            var model = await Context.OrderDetails.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<OrderDetails> Remove(long id)
        {
            var model = await Context.OrderDetails.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.OrderDetails.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

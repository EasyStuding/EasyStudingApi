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
    public class OrderAttachmentRepository: IRepository<OrderAttachment>
    {
        private readonly EasyStudingContext Context;

        public OrderAttachmentRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OrderAttachment> GetAll()
        {
            return Context.OrderAttachments;
        }

        public async Task<OrderAttachment> Get(long id)
        {
            return await Context.OrderAttachments.FindAsync(id);
        }

        public async Task<OrderAttachment> Add(OrderAttachment param)
        {
            await Context.OrderAttachments.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.OrderAttachments.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<OrderAttachment> Edit(OrderAttachment param)
        {
            var model = await Context.OrderAttachments.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<OrderAttachment> Remove(long id)
        {
            var model = await Context.OrderAttachments.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.OrderAttachments.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

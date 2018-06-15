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
    public class OrderAttachmentRepository: IRepository<OrderAttachment>
    {
        private readonly EasyStudingContext Context;

        public OrderAttachmentRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OrderAttachment> GetAll()
        {
            throw new Exception();
        }

        public async Task<OrderAttachment> Get(long id)
        {
            throw new Exception();
        }

        public async Task<OrderAttachment> Add(OrderAttachment param)
        {
            throw new Exception();
        }

        public async Task<OrderAttachment> Edit(OrderAttachment param)
        {
            throw new Exception();
        }

        public async Task<OrderAttachment> Remove(OrderAttachment param)
        {
            throw new Exception();
        }
    }
}

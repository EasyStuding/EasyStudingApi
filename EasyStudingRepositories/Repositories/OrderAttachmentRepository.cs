using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public OrderAttachment Get(long id)
        {
            throw new Exception();
        }

        public OrderAttachment Add(OrderAttachment param)
        {
            throw new Exception();
        }

        public OrderAttachment Edit(OrderAttachment param)
        {
            throw new Exception();
        }

        public OrderAttachment Remove(OrderAttachment param)
        {
            throw new Exception();
        }
    }
}

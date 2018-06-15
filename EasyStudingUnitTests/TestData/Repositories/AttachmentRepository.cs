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
    public class AttachmentRepository: IRepository<Attachment>
    {
        private readonly EasyStudingContext Context;

        public AttachmentRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Attachment> GetAll()
        {
            return Context.Attachments;
        }

        public async Task<Attachment> Get(long id)
        {
            return await Context.Attachments.FindAsync(id);
        }

        public async Task<Attachment> Add(Attachment param)
        {
            await Context.Attachments.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.Attachments.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<Attachment> Edit(Attachment param)
        {
            var model = await Context.Attachments.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<Attachment> Remove(long id)
        {
            var model = await Context.Attachments.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.Attachments.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

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
    public class OpenSourceAttachmentRepository: IRepository<OpenSourceAttachment>
    {
        private readonly EasyStudingContext Context;

        public OpenSourceAttachmentRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OpenSourceAttachment> GetAll()
        {
            return Context.OpenSourceAttachments;
        }

        public async Task<OpenSourceAttachment> Get(long id)
        {
            return await Context.OpenSourceAttachments.FindAsync(id);
        }

        public async Task<OpenSourceAttachment> Add(OpenSourceAttachment param)
        {
            await Context.OpenSourceAttachments.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.OpenSourceAttachments.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<OpenSourceAttachment> Edit(OpenSourceAttachment param)
        {
            var model = await Context.OpenSourceAttachments.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<OpenSourceAttachment> Remove(long id)
        {
            var model = await Context.OpenSourceAttachments.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.OpenSourceAttachments.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

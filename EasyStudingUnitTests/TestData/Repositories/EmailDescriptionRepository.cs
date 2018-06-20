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
    public class EmailDescriptionRepository: IRepository<EmailDescription>
    {
        private readonly EasyStudingContext Context;

        public EmailDescriptionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<EmailDescription> GetAll()
        {
            return Context.EmailDescriptions;
        }

        public async Task<EmailDescription> GetAsync(long id)
        {
            return await Context.EmailDescriptions.FindAsync(id);
        }

        public async Task<EmailDescription> AddAsync(EmailDescription param)
        {
            await Context.EmailDescriptions.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.EmailDescriptions.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<EmailDescription> EditAsync(EmailDescription param)
        {
            var model = await Context.EmailDescriptions.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<EmailDescription> RemoveAsync(long id)
        {
            var model = await Context.EmailDescriptions.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.EmailDescriptions.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

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
    public class OpenSourceRepository: IRepository<OpenSource>
    {
        private readonly EasyStudingContext Context;

        public OpenSourceRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OpenSource> GetAll()
        {
            return Context.OpenSources;
        }

        public async Task<OpenSource> GetAsync(long id)
        {
            return await Context.OpenSources.FindAsync(id);
        }

        public async Task<OpenSource> AddAsync(OpenSource param)
        {
            await Context.OpenSources.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.OpenSources.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<OpenSource> EditAsync(OpenSource param)
        {
            var model = await Context.OpenSources.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<OpenSource> RemoveAsync(long id)
        {
            var model = await Context.OpenSources.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.OpenSources.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

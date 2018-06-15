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
    public class BanDescriptionRepository: IRepository<BanDescription>
    {
        private readonly EasyStudingContext Context;

        public BanDescriptionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<BanDescription> GetAll()
        {
            return Context.BanDescriptions;
        }

        public async Task<BanDescription> Get(long id)
        {
            return await Context.BanDescriptions.FindAsync(id);
        }

        public async Task<BanDescription> Add(BanDescription param)
        {
            await Context.BanDescriptions.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.BanDescriptions.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<BanDescription> Edit(BanDescription param)
        {
            var model = await Context.BanDescriptions.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<BanDescription> Remove(long id)
        {
            var model = await Context.BanDescriptions.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.BanDescriptions.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

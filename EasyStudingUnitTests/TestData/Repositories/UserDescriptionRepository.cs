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
    public class UserDescriptionRepository: IRepository<UserDescription>
    {
        private readonly EasyStudingContext Context;

        public UserDescriptionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<UserDescription> GetAll()
        {
            return Context.UserDescriptions;
        }

        public async Task<UserDescription> Get(long id)
        {
            return await Context.UserDescriptions.FindAsync(id);
        }

        public async Task<UserDescription> Add(UserDescription param)
        {
            await Context.UserDescriptions.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.UserDescriptions.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<UserDescription> Edit(UserDescription param)
        {
            var model = await Context.UserDescriptions.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<UserDescription> Remove(long id)
        {
            var model = await Context.UserDescriptions.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.UserDescriptions.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

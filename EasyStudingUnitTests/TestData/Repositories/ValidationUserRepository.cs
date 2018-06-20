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
    public class ValidationUserRepository: IRepository<ValidationUser>
    {
        private readonly EasyStudingContext Context;

        public ValidationUserRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<ValidationUser> GetAll()
        {
            return Context.ValidationUsers;
        }

        public async Task<ValidationUser> GetAsync(long id)
        {
            return await Context.ValidationUsers.FindAsync(id);
        }

        public async Task<ValidationUser> AddAsync(ValidationUser param)
        {
            await Context.ValidationUsers.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.ValidationUsers.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<ValidationUser> EditAsync(ValidationUser param)
        {
            var model = await Context.ValidationUsers.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<ValidationUser> RemoveAsync(long id)
        {
            var model = await Context.ValidationUsers.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.ValidationUsers.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

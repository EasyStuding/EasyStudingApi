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
    public class UserRegistrationRepository: IRepository<UserRegistration>
    {
        private readonly EasyStudingContext Context;

        public UserRegistrationRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<UserRegistration> GetAll()
        {
            return Context.UserRegistrations;
        }

        public async Task<UserRegistration> GetAsync(long id)
        {
            return await Context.UserRegistrations.FindAsync(id);
        }

        public async Task<UserRegistration> AddAsync(UserRegistration param)
        {
            await Context.UserRegistrations.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.UserRegistrations.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<UserRegistration> EditAsync(UserRegistration param)
        {
            var model = await Context.UserRegistrations.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<UserRegistration> RemoveAsync(long id)
        {
            var model = await Context.UserRegistrations.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.UserRegistrations.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

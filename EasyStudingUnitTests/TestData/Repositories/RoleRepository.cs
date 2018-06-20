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
    public class RoleRepository: IRepository<Role>
    {
        private readonly EasyStudingContext Context;

        public RoleRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Role> GetAll()
        {
            return Context.Roles;
        }

        public async Task<Role> GetAsync(long id)
        {
            return await Context.Roles.FindAsync(id);
        }

        public async Task<Role> AddAsync(Role param)
        {
            await Context.Roles.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.Roles.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<Role> EditAsync(Role param)
        {
            var model = await Context.Roles.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<Role> RemoveAsync(long id)
        {
            var model = await Context.Roles.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.Roles.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

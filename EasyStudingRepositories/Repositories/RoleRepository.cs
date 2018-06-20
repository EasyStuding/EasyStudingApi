using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingRepositories.Repositories
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
            throw new Exception();
        }

        public async Task<Role> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<Role> AddAsync(Role param)
        {
            throw new Exception();
        }

        public async Task<Role> EditAsync(Role param)
        {
            throw new Exception();
        }

        public async Task<Role> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

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

        public async Task<Role> Get(long id)
        {
            throw new Exception();
        }

        public async Task<Role> Add(Role param)
        {
            throw new Exception();
        }

        public async Task<Role> Edit(Role param)
        {
            throw new Exception();
        }

        public async Task<Role> Remove(long id)
        {
            throw new Exception();
        }
    }
}

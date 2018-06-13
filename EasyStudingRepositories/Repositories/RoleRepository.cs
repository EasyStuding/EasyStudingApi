using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public Role Get(long id)
        {
            throw new Exception();
        }

        public Role Add(Role param)
        {
            throw new Exception();
        }

        public Role Edit(Role param)
        {
            throw new Exception();
        }

        public Role Remove(Role param)
        {
            throw new Exception();
        }
    }
}

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
    public class ValidationUserRepository: IRepository<ValidationUser>
    {
        private readonly EasyStudingContext Context;

        public ValidationUserRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<ValidationUser> GetAll()
        {
            throw new Exception();
        }

        public async Task<ValidationUser> Get(long id)
        {
            throw new Exception();
        }

        public async Task<ValidationUser> Add(ValidationUser param)
        {
            throw new Exception();
        }

        public async Task<ValidationUser> Edit(ValidationUser param)
        {
            throw new Exception();
        }

        public async Task<ValidationUser> Remove(ValidationUser param)
        {
            throw new Exception();
        }
    }
}

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

        public async Task<ValidationUser> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<ValidationUser> AddAsync(ValidationUser param)
        {
            throw new Exception();
        }

        public async Task<ValidationUser> EditAsync(ValidationUser param)
        {
            throw new Exception();
        }

        public async Task<ValidationUser> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

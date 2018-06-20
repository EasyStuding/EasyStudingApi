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
    public class UserDescriptionRepository: IRepository<UserDescription>
    {
        private readonly EasyStudingContext Context;

        public UserDescriptionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<UserDescription> GetAll()
        {
            throw new Exception();
        }

        public async Task<UserDescription> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<UserDescription> AddAsync(UserDescription param)
        {
            throw new Exception();
        }

        public async Task<UserDescription> EditAsync(UserDescription param)
        {
            throw new Exception();
        }

        public async Task<UserDescription> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

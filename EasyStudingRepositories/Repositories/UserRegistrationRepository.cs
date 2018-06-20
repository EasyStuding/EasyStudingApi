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
    public class UserRegistrationRepository: IRepository<UserRegistration>
    {
        private readonly EasyStudingContext Context;

        public UserRegistrationRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<UserRegistration> GetAll()
        {
            throw new Exception();
        }

        public async Task<UserRegistration> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<UserRegistration> AddAsync(UserRegistration param)
        {
            throw new Exception();
        }

        public async Task<UserRegistration> EditAsync(UserRegistration param)
        {
            throw new Exception();
        }

        public async Task<UserRegistration> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

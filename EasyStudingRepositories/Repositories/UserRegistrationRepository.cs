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

        public async Task<UserRegistration> Get(long id)
        {
            throw new Exception();
        }

        public async Task<UserRegistration> Add(UserRegistration param)
        {
            throw new Exception();
        }

        public async Task<UserRegistration> Edit(UserRegistration param)
        {
            throw new Exception();
        }

        public async Task<UserRegistration> Remove(long id)
        {
            throw new Exception();
        }
    }
}

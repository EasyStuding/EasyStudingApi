using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public UserRegistration Get(long id)
        {
            throw new Exception();
        }

        public UserRegistration Add(UserRegistration param)
        {
            throw new Exception();
        }

        public UserRegistration Edit(UserRegistration param)
        {
            throw new Exception();
        }

        public UserRegistration Remove(UserRegistration param)
        {
            throw new Exception();
        }
    }
}

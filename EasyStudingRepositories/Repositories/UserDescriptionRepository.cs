using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public UserDescription Get(long id)
        {
            throw new Exception();
        }

        public UserDescription Add(UserDescription param)
        {
            throw new Exception();
        }

        public UserDescription Edit(UserDescription param)
        {
            throw new Exception();
        }

        public UserDescription Remove(UserDescription param)
        {
            throw new Exception();
        }
    }
}

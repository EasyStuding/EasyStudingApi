using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public ValidationUser Get(long id)
        {
            throw new Exception();
        }

        public ValidationUser Add(ValidationUser param)
        {
            throw new Exception();
        }

        public ValidationUser Edit(ValidationUser param)
        {
            throw new Exception();
        }

        public ValidationUser Remove(ValidationUser param)
        {
            throw new Exception();
        }
    }
}

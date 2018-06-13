using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyStudingRepositories.Repositories
{
    public class ValidationEmailRepository: IRepository<ValidationEmail>
    {
        private readonly EasyStudingContext Context;

        public ValidationEmailRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<ValidationEmail> GetAll()
        {
            throw new Exception();
        }

        public ValidationEmail Get(long id)
        {
            throw new Exception();
        }

        public ValidationEmail Add(ValidationEmail param)
        {
            throw new Exception();
        }

        public ValidationEmail Edit(ValidationEmail param)
        {
            throw new Exception();
        }

        public ValidationEmail Remove(ValidationEmail param)
        {
            throw new Exception();
        }
    }
}

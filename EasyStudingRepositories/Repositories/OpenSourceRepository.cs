using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyStudingRepositories.Repositories
{
    public class OpenSourceRepository: IRepository<OpenSource>
    {
        private readonly EasyStudingContext Context;

        public OpenSourceRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OpenSource> GetAll()
        {
            throw new Exception();
        }

        public OpenSource Get(long id)
        {
            throw new Exception();
        }

        public OpenSource Add(OpenSource param)
        {
            throw new Exception();
        }

        public OpenSource Edit(OpenSource param)
        {
            throw new Exception();
        }

        public OpenSource Remove(OpenSource param)
        {
            throw new Exception();
        }
    }
}

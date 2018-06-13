using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyStudingRepositories.Repositories
{
    public class EducationRepository: IRepository<Education>
    {
        private readonly EasyStudingContext Context;

        public EducationRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Education> GetAll()
        {
            throw new Exception();
        }

        public Education Get(long id)
        {
            throw new Exception();
        }

        public Education Add(Education param)
        {
            throw new Exception();
        }

        public Education Edit(Education param)
        {
            throw new Exception();
        }

        public Education Remove(Education param)
        {
            throw new Exception();
        }
    }
}

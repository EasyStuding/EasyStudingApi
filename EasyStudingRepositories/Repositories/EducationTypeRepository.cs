using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyStudingRepositories.Repositories
{
    public class EducationTypeRepository: IRepository<EducationType>
    {
        private readonly EasyStudingContext Context;

        public EducationTypeRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<EducationType> GetAll()
        {
            throw new Exception();
        }

        public EducationType Get(long id)
        {
            throw new Exception();
        }

        public EducationType Add(EducationType param)
        {
            throw new Exception();
        }

        public EducationType Edit(EducationType param)
        {
            throw new Exception();
        }

        public EducationType Remove(EducationType param)
        {
            throw new Exception();
        }
    }
}

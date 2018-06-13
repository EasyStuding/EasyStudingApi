using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyStudingRepositories.Repositories
{
    public class EducationUserDescriptionRepository: IRepository<EducationUserDescription>
    {
        private readonly EasyStudingContext Context;

        public EducationUserDescriptionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<EducationUserDescription> GetAll()
        {
            throw new Exception();
        }

        public EducationUserDescription Get(long id)
        {
            throw new Exception();
        }

        public EducationUserDescription Add(EducationUserDescription param)
        {
            throw new Exception();
        }

        public EducationUserDescription Edit(EducationUserDescription param)
        {
            throw new Exception();
        }

        public EducationUserDescription Remove(EducationUserDescription param)
        {
            throw new Exception();
        }
    }
}

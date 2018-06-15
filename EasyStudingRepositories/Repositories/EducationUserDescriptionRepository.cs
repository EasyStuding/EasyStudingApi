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

        public async Task<EducationUserDescription> Get(long id)
        {
            throw new Exception();
        }

        public async Task<EducationUserDescription> Add(EducationUserDescription param)
        {
            throw new Exception();
        }

        public async Task<EducationUserDescription> Edit(EducationUserDescription param)
        {
            throw new Exception();
        }

        public async Task<EducationUserDescription> Remove(EducationUserDescription param)
        {
            throw new Exception();
        }
    }
}

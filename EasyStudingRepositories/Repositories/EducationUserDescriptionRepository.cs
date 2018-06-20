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

        public async Task<EducationUserDescription> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<EducationUserDescription> AddAsync(EducationUserDescription param)
        {
            throw new Exception();
        }

        public async Task<EducationUserDescription> EditAsync(EducationUserDescription param)
        {
            throw new Exception();
        }

        public async Task<EducationUserDescription> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

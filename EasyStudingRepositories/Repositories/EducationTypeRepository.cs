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

        public async Task<EducationType> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<EducationType> AddAsync(EducationType param)
        {
            throw new Exception();
        }

        public async Task<EducationType> EditAsync(EducationType param)
        {
            throw new Exception();
        }

        public async Task<EducationType> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

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

        public async Task<IQueryable<EducationType>> GetAll()
        {
            throw new Exception();
        }

        public async Task<EducationType> Get(long id)
        {
            throw new Exception();
        }

        public async Task<EducationType> Add(EducationType param)
        {
            throw new Exception();
        }

        public async Task<EducationType> Edit(EducationType param)
        {
            throw new Exception();
        }

        public async Task<EducationType> Remove(EducationType param)
        {
            throw new Exception();
        }
    }
}

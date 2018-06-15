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

        public async Task<Education> Get(long id)
        {
            throw new Exception();
        }

        public async Task<Education> Add(Education param)
        {
            throw new Exception();
        }

        public async Task<Education> Edit(Education param)
        {
            throw new Exception();
        }

        public async Task<Education> Remove(long id)
        {
            throw new Exception();
        }
    }
}

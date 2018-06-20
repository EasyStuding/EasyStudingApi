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

        public async Task<Education> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<Education> AddAsync(Education param)
        {
            throw new Exception();
        }

        public async Task<Education> EditAsync(Education param)
        {
            throw new Exception();
        }

        public async Task<Education> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

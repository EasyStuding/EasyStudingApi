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

        public async Task<OpenSource> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<OpenSource> AddAsync(OpenSource param)
        {
            throw new Exception();
        }

        public async Task<OpenSource> EditAsync(OpenSource param)
        {
            throw new Exception();
        }

        public async Task<OpenSource> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

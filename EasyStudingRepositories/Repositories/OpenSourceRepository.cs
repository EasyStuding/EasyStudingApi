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

        public async Task<OpenSource> Get(long id)
        {
            throw new Exception();
        }

        public async Task<OpenSource> Add(OpenSource param)
        {
            throw new Exception();
        }

        public async Task<OpenSource> Edit(OpenSource param)
        {
            throw new Exception();
        }

        public async Task<OpenSource> Remove(OpenSource param)
        {
            throw new Exception();
        }
    }
}

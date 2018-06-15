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
    public class OpenTransactionRepository: IRepository<OpenTransaction>
    {
        private readonly EasyStudingContext Context;

        public OpenTransactionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OpenTransaction> GetAll()
        {
            throw new Exception();
        }

        public async Task<OpenTransaction> Get(long id)
        {
            throw new Exception();
        }

        public async Task<OpenTransaction> Add(OpenTransaction param)
        {
            throw new Exception();
        }

        public async Task<OpenTransaction> Edit(OpenTransaction param)
        {
            throw new Exception();
        }

        public async Task<OpenTransaction> Remove(long id)
        {
            throw new Exception();
        }
    }
}

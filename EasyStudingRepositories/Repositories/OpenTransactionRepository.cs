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

        public async Task<OpenTransaction> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<OpenTransaction> AddAsync(OpenTransaction param)
        {
            throw new Exception();
        }

        public async Task<OpenTransaction> EditAsync(OpenTransaction param)
        {
            throw new Exception();
        }

        public async Task<OpenTransaction> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

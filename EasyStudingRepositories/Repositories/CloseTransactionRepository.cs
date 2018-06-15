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
    public class CloseTransactionRepository: IRepository<CloseTransaction>
    {
        private readonly EasyStudingContext Context;

        public CloseTransactionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<CloseTransaction> GetAll()
        {
            throw new Exception();
        }

        public async Task<CloseTransaction> Get(long id)
        {
            throw new Exception();
        }

        public async Task<CloseTransaction> Add(CloseTransaction param)
        {
            throw new Exception();
        }

        public async Task<CloseTransaction> Edit(CloseTransaction param)
        {
            throw new Exception();
        }

        public async Task<CloseTransaction> Remove(CloseTransaction param)
        {
            throw new Exception();
        }
    }
}

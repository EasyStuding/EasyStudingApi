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

        public async Task<CloseTransaction> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<CloseTransaction> AddAsync(CloseTransaction param)
        {
            throw new Exception();
        }

        public async Task<CloseTransaction> EditAsync(CloseTransaction param)
        {
            throw new Exception();
        }

        public async Task<CloseTransaction> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

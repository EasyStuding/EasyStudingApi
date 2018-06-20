using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData.Repositories
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
            return Context.CloseTransactions;
        }

        public async Task<CloseTransaction> GetAsync(long id)
        {
            return await Context.CloseTransactions.FindAsync(id);
        }

        public async Task<CloseTransaction> AddAsync(CloseTransaction param)
        {
            await Context.CloseTransactions.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.CloseTransactions.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<CloseTransaction> EditAsync(CloseTransaction param)
        {
            var model = await Context.CloseTransactions.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<CloseTransaction> RemoveAsync(long id)
        {
            var model = await Context.CloseTransactions.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.CloseTransactions.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

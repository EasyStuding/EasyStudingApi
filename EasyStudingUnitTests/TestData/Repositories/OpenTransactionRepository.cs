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
    public class OpenTransactionRepository: IRepository<OpenTransaction>
    {
        private readonly EasyStudingContext Context;

        public OpenTransactionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OpenTransaction> GetAll()
        {
            return Context.OpenTransactions;
        }

        public async Task<OpenTransaction> Get(long id)
        {
            return await Context.OpenTransactions.FindAsync(id);
        }

        public async Task<OpenTransaction> Add(OpenTransaction param)
        {
            await Context.OpenTransactions.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.OpenTransactions.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<OpenTransaction> Edit(OpenTransaction param)
        {
            var model = await Context.OpenTransactions.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<OpenTransaction> Remove(long id)
        {
            var model = await Context.OpenTransactions.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.OpenTransactions.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

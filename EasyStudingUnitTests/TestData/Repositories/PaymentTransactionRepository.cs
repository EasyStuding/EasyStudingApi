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
    public class PaymentTransactionRepository: IRepository<PaymentTransaction>
    {
        private readonly EasyStudingContext Context;

        public PaymentTransactionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<PaymentTransaction> GetAll()
        {
            return Context.PaymentTransactions;
        }

        public async Task<PaymentTransaction> GetAsync(long id)
        {
            return await Context.PaymentTransactions.FindAsync(id);
        }

        public async Task<PaymentTransaction> AddAsync(PaymentTransaction param)
        {
            await Context.PaymentTransactions.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.PaymentTransactions.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<PaymentTransaction> EditAsync(PaymentTransaction param)
        {
            var model = await Context.PaymentTransactions.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<PaymentTransaction> RemoveAsync(long id)
        {
            var model = await Context.PaymentTransactions.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.PaymentTransactions.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

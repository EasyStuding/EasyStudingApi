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
    public class PaymentTransactionRepository: IRepository<PaymentTransaction>
    {
        private readonly EasyStudingContext Context;

        public PaymentTransactionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<PaymentTransaction> GetAll()
        {
            throw new Exception();
        }

        public async Task<PaymentTransaction> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<PaymentTransaction> AddAsync(PaymentTransaction param)
        {
            throw new Exception();
        }

        public async Task<PaymentTransaction> EditAsync(PaymentTransaction param)
        {
            throw new Exception();
        }

        public async Task<PaymentTransaction> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

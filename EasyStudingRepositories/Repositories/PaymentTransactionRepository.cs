using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public PaymentTransaction Get(long id)
        {
            throw new Exception();
        }

        public PaymentTransaction Add(PaymentTransaction param)
        {
            throw new Exception();
        }

        public PaymentTransaction Edit(PaymentTransaction param)
        {
            throw new Exception();
        }

        public PaymentTransaction Remove(PaymentTransaction param)
        {
            throw new Exception();
        }
    }
}

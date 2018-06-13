using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public CloseTransaction Get(long id)
        {
            throw new Exception();
        }

        public CloseTransaction Add(CloseTransaction param)
        {
            throw new Exception();
        }

        public CloseTransaction Edit(CloseTransaction param)
        {
            throw new Exception();
        }

        public CloseTransaction Remove(CloseTransaction param)
        {
            throw new Exception();
        }
    }
}

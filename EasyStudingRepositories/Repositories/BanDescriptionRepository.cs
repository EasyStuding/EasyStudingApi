using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyStudingRepositories.Repositories
{
    public class BanDescriptionRepository: IRepository<BanDescription>
    {
        private readonly EasyStudingContext Context;

        public BanDescriptionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<BanDescription> GetAll()
        {
            throw new Exception();
        }

        public BanDescription Get(long id)
        {
            throw new Exception();
        }

        public BanDescription Add(BanDescription param)
        {
            throw new Exception();
        }

        public BanDescription Edit(BanDescription param)
        {
            throw new Exception();
        }

        public BanDescription Remove(BanDescription param)
        {
            throw new Exception();
        }
    }
}

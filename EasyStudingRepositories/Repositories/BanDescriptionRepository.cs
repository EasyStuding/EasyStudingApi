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

        public async Task<BanDescription> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<BanDescription> AddAsync(BanDescription param)
        {
            throw new Exception();
        }

        public async Task<BanDescription> EditAsync(BanDescription param)
        {
            throw new Exception();
        }

        public async Task<BanDescription> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

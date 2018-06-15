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
    public class ReviewRepository: IRepository<Review>
    {
        private readonly EasyStudingContext Context;

        public ReviewRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Review> GetAll()
        {
            throw new Exception();
        }

        public async Task<Review> Get(long id)
        {
            throw new Exception();
        }

        public async Task<Review> Add(Review param)
        {
            throw new Exception();
        }

        public async Task<Review> Edit(Review param)
        {
            throw new Exception();
        }

        public async Task<Review> Remove(Review param)
        {
            throw new Exception();
        }
    }
}

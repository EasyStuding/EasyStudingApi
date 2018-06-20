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
    public class ReviewRepository: IRepository<Review>
    {
        private readonly EasyStudingContext Context;

        public ReviewRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Review> GetAll()
        {
            return Context.Reviews;
        }

        public async Task<Review> GetAsync(long id)
        {
            return await Context.Reviews.FindAsync(id);
        }

        public async Task<Review> AddAsync(Review param)
        {
            await Context.Reviews.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.Reviews.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<Review> EditAsync(Review param)
        {
            var model = await Context.Reviews.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<Review> RemoveAsync(long id)
        {
            var model = await Context.Reviews.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.Reviews.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

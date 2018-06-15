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
    public class UserPictureRepository: IRepository<UserPicture>
    {
        private readonly EasyStudingContext Context;

        public UserPictureRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<UserPicture> GetAll()
        {
            return Context.UserPictures;
        }

        public async Task<UserPicture> Get(long id)
        {
            return await Context.UserPictures.FindAsync(id);
        }

        public async Task<UserPicture> Add(UserPicture param)
        {
            await Context.UserPictures.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.UserPictures.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<UserPicture> Edit(UserPicture param)
        {
            var model = await Context.UserPictures.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<UserPicture> Remove(long id)
        {
            var model = await Context.UserPictures.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.UserPictures.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

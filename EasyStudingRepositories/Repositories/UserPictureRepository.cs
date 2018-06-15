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
    public class UserPictureRepository: IRepository<UserPicture>
    {
        private readonly EasyStudingContext Context;

        public UserPictureRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<UserPicture> GetAll()
        {
            throw new Exception();
        }

        public async Task<UserPicture> Get(long id)
        {
            throw new Exception();
        }

        public async Task<UserPicture> Add(UserPicture param)
        {
            throw new Exception();
        }

        public async Task<UserPicture> Edit(UserPicture param)
        {
            throw new Exception();
        }

        public async Task<UserPicture> Remove(UserPicture param)
        {
            throw new Exception();
        }
    }
}

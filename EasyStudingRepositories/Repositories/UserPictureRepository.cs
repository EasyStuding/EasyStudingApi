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

        public async Task<UserPicture> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<UserPicture> AddAsync(UserPicture param)
        {
            throw new Exception();
        }

        public async Task<UserPicture> EditAsync(UserPicture param)
        {
            throw new Exception();
        }

        public async Task<UserPicture> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

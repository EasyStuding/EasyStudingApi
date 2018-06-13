using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public UserPicture Get(long id)
        {
            throw new Exception();
        }

        public UserPicture Add(UserPicture param)
        {
            throw new Exception();
        }

        public UserPicture Edit(UserPicture param)
        {
            throw new Exception();
        }

        public UserPicture Remove(UserPicture param)
        {
            throw new Exception();
        }
    }
}

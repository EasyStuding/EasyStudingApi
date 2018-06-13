using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyStudingRepositories.Repositories
{
    public class UserInformationRepository: IRepository<UserInformation>
    {
        private readonly EasyStudingContext Context;

        public UserInformationRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<UserInformation> GetAll()
        {
            throw new Exception();
        }

        public UserInformation Get(long id)
        {
            throw new Exception();
        }

        public UserInformation Add(UserInformation param)
        {
            throw new Exception();
        }

        public UserInformation Edit(UserInformation param)
        {
            throw new Exception();
        }

        public UserInformation Remove(UserInformation param)
        {
            throw new Exception();
        }
    }
}

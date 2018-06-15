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

        public async Task<UserInformation> Get(long id)
        {
            throw new Exception();
        }

        public async Task<UserInformation> Add(UserInformation param)
        {
            throw new Exception();
        }

        public async Task<UserInformation> Edit(UserInformation param)
        {
            throw new Exception();
        }

        public async Task<UserInformation> Remove(long id)
        {
            throw new Exception();
        }
    }
}

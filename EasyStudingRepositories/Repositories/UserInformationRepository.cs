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

        public async Task<UserInformation> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<UserInformation> AddAsync(UserInformation param)
        {
            throw new Exception();
        }

        public async Task<UserInformation> EditAsync(UserInformation param)
        {
            throw new Exception();
        }

        public async Task<UserInformation> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

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
    public class ValidationEmailRepository: IRepository<ValidationEmail>
    {
        private readonly EasyStudingContext Context;

        public ValidationEmailRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<ValidationEmail> GetAll()
        {
            throw new Exception();
        }

        public async Task<ValidationEmail> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<ValidationEmail> AddAsync(ValidationEmail param)
        {
            throw new Exception();
        }

        public async Task<ValidationEmail> EditAsync(ValidationEmail param)
        {
            throw new Exception();
        }

        public async Task<ValidationEmail> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

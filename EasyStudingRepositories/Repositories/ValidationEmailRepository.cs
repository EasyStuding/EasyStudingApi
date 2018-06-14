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

        public async Task<IQueryable<ValidationEmail>> GetAll()
        {
            throw new Exception();
        }

        public async Task<ValidationEmail> Get(long id)
        {
            throw new Exception();
        }

        public async Task<ValidationEmail> Add(ValidationEmail param)
        {
            throw new Exception();
        }

        public async Task<ValidationEmail> Edit(ValidationEmail param)
        {
            throw new Exception();
        }

        public async Task<ValidationEmail> Remove(ValidationEmail param)
        {
            throw new Exception();
        }
    }
}

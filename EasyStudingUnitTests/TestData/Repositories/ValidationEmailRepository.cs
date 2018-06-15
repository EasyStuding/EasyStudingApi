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
    public class ValidationEmailRepository: IRepository<ValidationEmail>
    {
        private readonly EasyStudingContext Context;

        public ValidationEmailRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<ValidationEmail> GetAll()
        {
            return Context.ValidationEmails;
        }

        public async Task<ValidationEmail> Get(long id)
        {
            return await Context.ValidationEmails.FindAsync(id);
        }

        public async Task<ValidationEmail> Add(ValidationEmail param)
        {
            await Context.ValidationEmails.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.ValidationEmails.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<ValidationEmail> Edit(ValidationEmail param)
        {
            var model = await Context.ValidationEmails.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<ValidationEmail> Remove(long id)
        {
            var model = await Context.ValidationEmails.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.ValidationEmails.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

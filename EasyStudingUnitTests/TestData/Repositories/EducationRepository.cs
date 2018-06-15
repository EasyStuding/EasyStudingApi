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
    public class EducationRepository: IRepository<Education>
    {
        private readonly EasyStudingContext Context;

        public EducationRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Education> GetAll()
        {
            return Context.Educations;
        }

        public async Task<Education> Get(long id)
        {
            return await Context.Educations.FindAsync(id);
        }

        public async Task<Education> Add(Education param)
        {
            await Context.Educations.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.Educations.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<Education> Edit(Education param)
        {
            var model = await Context.Educations.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<Education> Remove(long id)
        {
            var model = await Context.Educations.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.Educations.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

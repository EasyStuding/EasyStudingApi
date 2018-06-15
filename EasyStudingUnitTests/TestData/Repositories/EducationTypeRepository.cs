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
    public class EducationTypeRepository: IRepository<EducationType>
    {
        private readonly EasyStudingContext Context;

        public EducationTypeRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<EducationType> GetAll()
        {
            return Context.EducationTypes;
        }

        public async Task<EducationType> Get(long id)
        {
            return await Context.EducationTypes.FindAsync(id);
        }

        public async Task<EducationType> Add(EducationType param)
        {
            await Context.EducationTypes.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.EducationTypes.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<EducationType> Edit(EducationType param)
        {
            var model = await Context.EducationTypes.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<EducationType> Remove(long id)
        {
            var model = await Context.EducationTypes.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.EducationTypes.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

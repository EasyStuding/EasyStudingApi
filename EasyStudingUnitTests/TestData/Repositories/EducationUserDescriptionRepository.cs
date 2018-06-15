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
    public class EducationUserDescriptionRepository: IRepository<EducationUserDescription>
    {
        private readonly EasyStudingContext Context;

        public EducationUserDescriptionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<EducationUserDescription> GetAll()
        {
            return Context.EducationUserDescriptions;
        }

        public async Task<EducationUserDescription> Get(long id)
        {
            return await Context.EducationUserDescriptions.FindAsync(id);
        }

        public async Task<EducationUserDescription> Add(EducationUserDescription param)
        {
            await Context.EducationUserDescriptions.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.EducationUserDescriptions.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<EducationUserDescription> Edit(EducationUserDescription param)
        {
            var model = await Context.EducationUserDescriptions.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<EducationUserDescription> Remove(long id)
        {
            var model = await Context.EducationUserDescriptions.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.EducationUserDescriptions.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

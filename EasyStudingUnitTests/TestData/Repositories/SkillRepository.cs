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
    public class SkillRepository: IRepository<Skill>
    {
        private readonly EasyStudingContext Context;

        public SkillRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Skill> GetAll()
        {
            return Context.Skills;
        }

        public async Task<Skill> GetAsync(long id)
        {
            return await Context.Skills.FindAsync(id);
        }

        public async Task<Skill> AddAsync(Skill param)
        {
            await Context.Skills.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.Skills.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<Skill> EditAsync(Skill param)
        {
            var model = await Context.Skills.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<Skill> RemoveAsync(long id)
        {
            var model = await Context.Skills.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.Skills.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

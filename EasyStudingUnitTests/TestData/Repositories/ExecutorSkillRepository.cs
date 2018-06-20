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
    public class ExecutorSkillRepository: IRepository<ExecutorSkill>
    {
        private readonly EasyStudingContext Context;

        public ExecutorSkillRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<ExecutorSkill> GetAll()
        {
            return Context.ExecutorSkills;
        }

        public async Task<ExecutorSkill> GetAsync(long id)
        {
            return await Context.ExecutorSkills.FindAsync(id);
        }

        public async Task<ExecutorSkill> AddAsync(ExecutorSkill param)
        {
            await Context.ExecutorSkills.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.ExecutorSkills.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<ExecutorSkill> EditAsync(ExecutorSkill param)
        {
            var model = await Context.ExecutorSkills.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<ExecutorSkill> RemoveAsync(long id)
        {
            var model = await Context.ExecutorSkills.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.ExecutorSkills.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

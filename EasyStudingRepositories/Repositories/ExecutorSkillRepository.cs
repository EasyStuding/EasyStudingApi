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
    public class ExecutorSkillRepository: IRepository<ExecutorSkill>
    {
        private readonly EasyStudingContext Context;

        public ExecutorSkillRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<ExecutorSkill> GetAll()
        {
            throw new Exception();
        }

        public async Task<ExecutorSkill> Get(long id)
        {
            throw new Exception();
        }

        public async Task<ExecutorSkill> Add(ExecutorSkill param)
        {
            throw new Exception();
        }

        public async Task<ExecutorSkill> Edit(ExecutorSkill param)
        {
            throw new Exception();
        }

        public async Task<ExecutorSkill> Remove(long id)
        {
            throw new Exception();
        }
    }
}

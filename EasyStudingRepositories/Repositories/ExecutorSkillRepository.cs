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

        public async Task<ExecutorSkill> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<ExecutorSkill> AddAsync(ExecutorSkill param)
        {
            throw new Exception();
        }

        public async Task<ExecutorSkill> EditAsync(ExecutorSkill param)
        {
            throw new Exception();
        }

        public async Task<ExecutorSkill> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

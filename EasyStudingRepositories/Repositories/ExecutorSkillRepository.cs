using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public ExecutorSkill Get(long id)
        {
            throw new Exception();
        }

        public ExecutorSkill Add(ExecutorSkill param)
        {
            throw new Exception();
        }

        public ExecutorSkill Edit(ExecutorSkill param)
        {
            throw new Exception();
        }

        public ExecutorSkill Remove(ExecutorSkill param)
        {
            throw new Exception();
        }
    }
}

using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasyStudingRepositories.Repositories
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
            throw new Exception();
        }

        public Skill Get(long id)
        {
            throw new Exception();
        }

        public Skill Add(Skill param)
        {
            throw new Exception();
        }

        public Skill Edit(Skill param)
        {
            throw new Exception();
        }

        public Skill Remove(Skill param)
        {
            throw new Exception();
        }
    }
}

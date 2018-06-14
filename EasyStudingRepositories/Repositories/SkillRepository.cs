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
    public class SkillRepository: IRepository<Skill>
    {
        private readonly EasyStudingContext Context;

        public SkillRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public async Task<IQueryable<Skill>> GetAll()
        {
            throw new Exception();
        }

        public async Task<Skill> Get(long id)
        {
            throw new Exception();
        }

        public async Task<Skill> Add(Skill param)
        {
            throw new Exception();
        }

        public async Task<Skill> Edit(Skill param)
        {
            throw new Exception();
        }

        public async Task<Skill> Remove(Skill param)
        {
            throw new Exception();
        }
    }
}

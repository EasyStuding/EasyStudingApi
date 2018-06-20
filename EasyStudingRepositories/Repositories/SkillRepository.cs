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

        public IQueryable<Skill> GetAll()
        {
            throw new Exception();
        }

        public async Task<Skill> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<Skill> AddAsync(Skill param)
        {
            throw new Exception();
        }

        public async Task<Skill> EditAsync(Skill param)
        {
            throw new Exception();
        }

        public async Task<Skill> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

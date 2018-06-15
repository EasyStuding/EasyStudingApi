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
    public class OrderSkillRepository: IRepository<OrderSkill>
    {
        private readonly EasyStudingContext Context;

        public OrderSkillRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OrderSkill> GetAll()
        {
            throw new Exception();
        }

        public async Task<OrderSkill> Get(long id)
        {
            throw new Exception();
        }

        public async Task<OrderSkill> Add(OrderSkill param)
        {
            throw new Exception();
        }

        public async Task<OrderSkill> Edit(OrderSkill param)
        {
            throw new Exception();
        }

        public async Task<OrderSkill> Remove(long id)
        {
            throw new Exception();
        }
    }
}

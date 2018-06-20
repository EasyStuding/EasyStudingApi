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

        public async Task<OrderSkill> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<OrderSkill> AddAsync(OrderSkill param)
        {
            throw new Exception();
        }

        public async Task<OrderSkill> EditAsync(OrderSkill param)
        {
            throw new Exception();
        }

        public async Task<OrderSkill> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

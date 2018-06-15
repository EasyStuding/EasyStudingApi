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
    public class OrderSkillRepository: IRepository<OrderSkill>
    {
        private readonly EasyStudingContext Context;

        public OrderSkillRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OrderSkill> GetAll()
        {
            return Context.OrderSkills;
        }

        public async Task<OrderSkill> Get(long id)
        {
            return await Context.OrderSkills.FindAsync(id);
        }

        public async Task<OrderSkill> Add(OrderSkill param)
        {
            await Context.OrderSkills.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.OrderSkills.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<OrderSkill> Edit(OrderSkill param)
        {
            var model = await Context.OrderSkills.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<OrderSkill> Remove(long id)
        {
            var model = await Context.OrderSkills.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.OrderSkills.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

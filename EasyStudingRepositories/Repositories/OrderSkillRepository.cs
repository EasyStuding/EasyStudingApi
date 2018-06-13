using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public OrderSkill Get(long id)
        {
            throw new Exception();
        }

        public OrderSkill Add(OrderSkill param)
        {
            throw new Exception();
        }

        public OrderSkill Edit(OrderSkill param)
        {
            throw new Exception();
        }

        public OrderSkill Remove(OrderSkill param)
        {
            throw new Exception();
        }
    }
}

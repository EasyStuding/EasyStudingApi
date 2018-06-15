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
    public class StateRepository: IRepository<State>
    {
        private readonly EasyStudingContext Context;

        public StateRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<State> GetAll()
        {
            return Context.States;
        }

        public async Task<State> Get(long id)
        {
            return await Context.States.FindAsync(id);
        }

        public async Task<State> Add(State param)
        {
            await Context.States.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.States.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<State> Edit(State param)
        {
            var model = await Context.States.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<State> Remove(long id)
        {
            var model = await Context.States.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.States.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

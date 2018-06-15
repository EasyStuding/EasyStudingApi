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
    public class StateRepository: IRepository<State>
    {
        private readonly EasyStudingContext Context;

        public StateRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<State> GetAll()
        {
            throw new Exception();
        }

        public async Task<State> Get(long id)
        {
            throw new Exception();
        }

        public async Task<State> Add(State param)
        {
            throw new Exception();
        }

        public async Task<State> Edit(State param)
        {
            throw new Exception();
        }

        public async Task<State> Remove(long id)
        {
            throw new Exception();
        }
    }
}

﻿using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData.Repositories
{
    public class UserInformationRepository: IRepository<UserInformation>
    {
        private readonly EasyStudingContext Context;

        public UserInformationRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<UserInformation> GetAll()
        {
            return Context.UserInformations;
        }

        public async Task<UserInformation> Get(long id)
        {
            return await Context.UserInformations.FindAsync(id);
        }

        public async Task<UserInformation> Add(UserInformation param)
        {
            await Context.UserInformations.AddAsync(param);

            await Context.SaveChangesAsync();

            param.Id = (await Context.UserInformations.FindAsync(param.Id)).Id;

            return param;
        }

        public async Task<UserInformation> Edit(UserInformation param)
        {
            var model = await Context.UserInformations.FindAsync(param.Id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            return model;
        }

        public async Task<UserInformation> Remove(long id)
        {
            var model = await Context.UserInformations.FindAsync(id);

            if (model == null)
            {
                throw new IndexOutOfRangeException();
            }

            Context.UserInformations.Remove(model);

            await Context.SaveChangesAsync();

            return model;
        }
    }
}

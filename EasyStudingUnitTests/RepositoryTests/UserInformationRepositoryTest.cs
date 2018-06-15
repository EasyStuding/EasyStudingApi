﻿using EasyStudingRepositories.DbContext;
using EasyStudingRepositories.Repositories;
using EasyStudingModels.DbContextModels;
using EasyStudingUnitTests.TestData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;

namespace EasyStudingUnitTests.RepositoryTests
{
    public class UserInformationRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "UserInformationRepository.GetAll() should return 5 objects.")]
        public void UserInformationRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserInformationRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "UserInformationRepository.Get(1) should return first object.")]
        public async void UserInformationRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserInformationRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "UserInformationRepository.Add(model) should return valid model.")]
        public async void UserInformationRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserInformationRepository(Context);
                var model = await rep.Add(new UserInformation() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "UserInformationRepository.Add(null) should return argument null exception.")]
        public async void UserInformationRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserInformationRepository(Context);
                try
                {
                    var model = await rep.Add(null);
                    Assert.True(false);
                }
                catch (ArgumentNullException)
                {
                    Assert.True(true);
                }
            }
        }

        [Fact(DisplayName = "UserInformationRepository.Edit(model) should return valid model.")]
        public async void UserInformationRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserInformationRepository(Context);
                var model = await rep.Edit(new UserInformation() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "UserInformationRepository.Edit(null) should return argument null exception.")]
        public async void UserInformationRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserInformationRepository(Context);
                try
                {
                    var model = await rep.Edit(null);
                    Assert.True(false);
                }
                catch (ArgumentNullException)
                {
                    Assert.True(true);
                }
            }
        }

        [Fact(DisplayName = "UserInformationRepository.Remove(model) should return valid model.")]
        public async void UserInformationRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserInformationRepository(Context);
                var model = await rep.Remove(new UserInformation() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "UserInformationRepository.Remove(null) should return argument null exception.")]
        public async void UserInformationRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserInformationRepository(Context);
                try
                {
                    var model = await rep.Remove(null);
                    Assert.True(false);
                }
                catch (ArgumentNullException)
                {
                    Assert.True(true);
                }
            }
        }
    }
}

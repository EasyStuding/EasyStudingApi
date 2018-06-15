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
    public class ValidationEmailRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "ValidationEmailRepository.GetAll() should return 5 objects.")]
        public void ValidationEmailRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationEmailRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "ValidationEmailRepository.Get(1) should return first object.")]
        public async void ValidationEmailRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationEmailRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ValidationEmailRepository.Add(model) should return valid model.")]
        public async void ValidationEmailRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationEmailRepository(Context);
                var model = await rep.Add(new ValidationEmail() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "ValidationEmailRepository.Add(null) should return argument null exception.")]
        public async void ValidationEmailRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationEmailRepository(Context);
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

        [Fact(DisplayName = "ValidationEmailRepository.Edit(model) should return valid model.")]
        public async void ValidationEmailRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationEmailRepository(Context);
                var model = await rep.Edit(new ValidationEmail() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "ValidationEmailRepository.Edit(null) should return argument null exception.")]
        public async void ValidationEmailRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationEmailRepository(Context);
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

        [Fact(DisplayName = "ValidationEmailRepository.Remove(model) should return valid model.")]
        public async void ValidationEmailRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationEmailRepository(Context);
                var model = await rep.Remove(new ValidationEmail() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "ValidationEmailRepository.Remove(null) should return argument null exception.")]
        public async void ValidationEmailRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationEmailRepository(Context);
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
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
    public class SubscriptionOpenSourceRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "SubscriptionOpenSourceRepository.GetAll() should return 5 objects.")]
        public void SubscriptionOpenSourceRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionOpenSourceRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "SubscriptionOpenSourceRepository.Get(1) should return first object.")]
        public async void SubscriptionOpenSourceRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionOpenSourceRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "SubscriptionOpenSourceRepository.Add(model) should return valid model.")]
        public async void SubscriptionOpenSourceRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionOpenSourceRepository(Context);
                var model = await rep.Add(new SubscriptionOpenSource() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "SubscriptionOpenSourceRepository.Add(null) should return argument null exception.")]
        public async void SubscriptionOpenSourceRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionOpenSourceRepository(Context);
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

        [Fact(DisplayName = "SubscriptionOpenSourceRepository.Edit(model) should return valid model.")]
        public async void SubscriptionOpenSourceRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionOpenSourceRepository(Context);
                var model = await rep.Edit(new SubscriptionOpenSource() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "SubscriptionOpenSourceRepository.Edit(null) should return argument null exception.")]
        public async void SubscriptionOpenSourceRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionOpenSourceRepository(Context);
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

        [Fact(DisplayName = "SubscriptionOpenSourceRepository.Remove(model) should return valid model.")]
        public async void SubscriptionOpenSourceRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionOpenSourceRepository(Context);
                var model = await rep.Remove(new SubscriptionOpenSource() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "SubscriptionOpenSourceRepository.Remove(null) should return argument null exception.")]
        public async void SubscriptionOpenSourceRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionOpenSourceRepository(Context);
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

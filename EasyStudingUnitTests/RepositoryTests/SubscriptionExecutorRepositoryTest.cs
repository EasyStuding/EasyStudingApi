using EasyStudingRepositories.DbContext;
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
    public class SubscriptionExecutorRepositoryTest
    {
        private EasyStudingContext Context;

        public SubscriptionExecutorRepositoryTest()
        {
            Context = new TestDbContext().Context;
        }

        [Fact(DisplayName = "SubscriptionExecutorRepository.GetAll() should return 5 objects.")]
        public async void SubscriptionExecutorRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionExecutorRepository(Context);
                var result = await rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "SubscriptionExecutorRepository.Get(1) should return first object.")]
        public async void SubscriptionExecutorRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionExecutorRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "SubscriptionExecutorRepository.Add(model) should return valid model.")]
        public async void SubscriptionExecutorRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionExecutorRepository(Context);
                var model = await rep.Add(new SubscriptionExecutor() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "SubscriptionExecutorRepository.Add(null) should return argument null exception.")]
        public async void SubscriptionExecutorRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionExecutorRepository(Context);
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

        [Fact(DisplayName = "SubscriptionExecutorRepository.Edit(model) should return valid model.")]
        public async void SubscriptionExecutorRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionExecutorRepository(Context);
                var model = await rep.Edit(new SubscriptionExecutor() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "SubscriptionExecutorRepository.Edit(null) should return argument null exception.")]
        public async void SubscriptionExecutorRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionExecutorRepository(Context);
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

        [Fact(DisplayName = "SubscriptionExecutorRepository.Remove(model) should return valid model.")]
        public async void SubscriptionExecutorRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionExecutorRepository(Context);
                var model = await rep.Remove(new SubscriptionExecutor() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "SubscriptionExecutorRepository.Remove(null) should return argument null exception.")]
        public async void SubscriptionExecutorRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new SubscriptionExecutorRepository(Context);
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

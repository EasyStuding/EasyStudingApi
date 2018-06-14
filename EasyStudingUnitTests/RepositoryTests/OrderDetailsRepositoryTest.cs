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
    public class OrderDetailsRepositoryTest
    {
        private EasyStudingContext Context;

        public OrderDetailsRepositoryTest()
        {
            Context = new TestDbContext().Context;
        }

        [Fact(DisplayName = "OrderDetailsRepository.GetAll() should return 5 objects.")]
        public async void OrderDetailsRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderDetailsRepository(Context);
                var result = await rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "OrderDetailsRepository.Get(1) should return first object.")]
        public async void OrderDetailsRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderDetailsRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "OrderDetailsRepository.Add(model) should return valid model.")]
        public async void OrderDetailsRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderDetailsRepository(Context);
                var model = await rep.Add(new OrderDetails() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "OrderDetailsRepository.Add(null) should return argument null exception.")]
        public async void OrderDetailsRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderDetailsRepository(Context);
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

        [Fact(DisplayName = "OrderDetailsRepository.Edit(model) should return valid model.")]
        public async void OrderDetailsRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderDetailsRepository(Context);
                var model = await rep.Edit(new OrderDetails() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "OrderDetailsRepository.Edit(null) should return argument null exception.")]
        public async void OrderDetailsRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderDetailsRepository(Context);
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

        [Fact(DisplayName = "OrderDetailsRepository.Remove(model) should return valid model.")]
        public async void OrderDetailsRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderDetailsRepository(Context);
                var model = await rep.Remove(new OrderDetails() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "OrderDetailsRepository.Remove(null) should return argument null exception.")]
        public async void OrderDetailsRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderDetailsRepository(Context);
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

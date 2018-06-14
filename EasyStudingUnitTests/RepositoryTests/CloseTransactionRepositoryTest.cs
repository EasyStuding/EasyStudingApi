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
    public class CloseTransactionRepositoryTest
    {
        private EasyStudingContext Context;

        public CloseTransactionRepositoryTest()
        {
            Context = new TestDbContext().Context;
        }

        [Fact(DisplayName = "CloseTransactionRepository.GetAll() should return 5 objects.")]
        public async void CloseTransactionRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CloseTransactionRepository(Context);
                var result = await rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "CloseTransactionRepository.Get(1) should return first object.")]
        public async void CloseTransactionRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CloseTransactionRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "CloseTransactionRepository.Add(model) should return valid model.")]
        public async void CloseTransactionRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CloseTransactionRepository(Context);
                var model = await rep.Add(new CloseTransaction() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "CloseTransactionRepository.Add(null) should return argument null exception.")]
        public async void CloseTransactionRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CloseTransactionRepository(Context);
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

        [Fact(DisplayName = "CloseTransactionRepository.Edit(model) should return valid model.")]
        public async void CloseTransactionRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CloseTransactionRepository(Context);
                var model = await rep.Edit(new CloseTransaction() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "CloseTransactionRepository.Edit(null) should return argument null exception.")]
        public async void CloseTransactionRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CloseTransactionRepository(Context);
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

        [Fact(DisplayName = "CloseTransactionRepository.Remove(model) should return valid model.")]
        public async void CloseTransactionRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CloseTransactionRepository(Context);
                var model = await rep.Remove(new CloseTransaction() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "CloseTransactionRepository.Remove(null) should return argument null exception.")]
        public async void CloseTransactionRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CloseTransactionRepository(Context);
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

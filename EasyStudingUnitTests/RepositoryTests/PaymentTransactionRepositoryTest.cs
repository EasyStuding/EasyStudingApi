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
    public class PaymentTransactionRepositoryTest
    {
        private EasyStudingContext Context;

        public PaymentTransactionRepositoryTest()
        {
            Context = new TestDbContext().Context;
        }

        [Fact(DisplayName = "PaymentTransactionRepository.GetAll() should return 5 objects.")]
        public async void PaymentTransactionRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new PaymentTransactionRepository(Context);
                var result = await rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "PaymentTransactionRepository.Get(1) should return first object.")]
        public async void PaymentTransactionRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new PaymentTransactionRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "PaymentTransactionRepository.Add(model) should return valid model.")]
        public async void PaymentTransactionRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new PaymentTransactionRepository(Context);
                var model = await rep.Add(new PaymentTransaction() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "PaymentTransactionRepository.Add(null) should return argument null exception.")]
        public async void PaymentTransactionRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new PaymentTransactionRepository(Context);
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

        [Fact(DisplayName = "PaymentTransactionRepository.Edit(model) should return valid model.")]
        public async void PaymentTransactionRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new PaymentTransactionRepository(Context);
                var model = await rep.Edit(new PaymentTransaction() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "PaymentTransactionRepository.Edit(null) should return argument null exception.")]
        public async void PaymentTransactionRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new PaymentTransactionRepository(Context);
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

        [Fact(DisplayName = "PaymentTransactionRepository.Remove(model) should return valid model.")]
        public async void PaymentTransactionRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new PaymentTransactionRepository(Context);
                var model = await rep.Remove(new PaymentTransaction() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "PaymentTransactionRepository.Remove(null) should return argument null exception.")]
        public async void PaymentTransactionRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new PaymentTransactionRepository(Context);
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

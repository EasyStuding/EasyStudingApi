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
    public class ValidationUserRepositoryTest
    {
        private EasyStudingContext Context;

        public ValidationUserRepositoryTest()
        {
            Context = new TestDbContext().Context;
        }

        [Fact(DisplayName = "ValidationUserRepository.GetAll() should return 5 objects.")]
        public async void ValidationUserRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationUserRepository(Context);
                var result = await rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "ValidationUserRepository.Get(1) should return first object.")]
        public async void ValidationUserRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationUserRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ValidationUserRepository.Add(model) should return valid model.")]
        public async void ValidationUserRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationUserRepository(Context);
                var model = await rep.Add(new ValidationUser() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "ValidationUserRepository.Add(null) should return argument null exception.")]
        public async void ValidationUserRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationUserRepository(Context);
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

        [Fact(DisplayName = "ValidationUserRepository.Edit(model) should return valid model.")]
        public async void ValidationUserRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationUserRepository(Context);
                var model = await rep.Edit(new ValidationUser() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "ValidationUserRepository.Edit(null) should return argument null exception.")]
        public async void ValidationUserRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationUserRepository(Context);
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

        [Fact(DisplayName = "ValidationUserRepository.Remove(model) should return valid model.")]
        public async void ValidationUserRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationUserRepository(Context);
                var model = await rep.Remove(new ValidationUser() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "ValidationUserRepository.Remove(null) should return argument null exception.")]
        public async void ValidationUserRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ValidationUserRepository(Context);
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

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
    public class UserDescriptionRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "UserDescriptionRepository.GetAll() should return 5 objects.")]
        public void UserDescriptionRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserDescriptionRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "UserDescriptionRepository.Get(1) should return first object.")]
        public async void UserDescriptionRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserDescriptionRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "UserDescriptionRepository.Add(model) should return valid model.")]
        public async void UserDescriptionRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserDescriptionRepository(Context);
                var model = await rep.Add(new UserDescription() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "UserDescriptionRepository.Add(null) should return argument null exception.")]
        public async void UserDescriptionRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserDescriptionRepository(Context);
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

        [Fact(DisplayName = "UserDescriptionRepository.Edit(model) should return valid model.")]
        public async void UserDescriptionRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserDescriptionRepository(Context);
                var model = await rep.Edit(new UserDescription() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "UserDescriptionRepository.Edit(null) should return argument null exception.")]
        public async void UserDescriptionRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserDescriptionRepository(Context);
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

        [Fact(DisplayName = "UserDescriptionRepository.Remove(model) should return valid model.")]
        public async void UserDescriptionRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserDescriptionRepository(Context);
                var model = await rep.Remove(new UserDescription() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "UserDescriptionRepository.Remove(null) should return argument null exception.")]
        public async void UserDescriptionRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserDescriptionRepository(Context);
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

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
    public class OpenSourceRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "OpenSourceRepository.GetAll() should return 5 objects.")]
        public void OpenSourceRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "OpenSourceRepository.Get(1) should return first object.")]
        public async void OpenSourceRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "OpenSourceRepository.Add(model) should return valid model.")]
        public async void OpenSourceRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceRepository(Context);
                var model = await rep.Add(new OpenSource() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "OpenSourceRepository.Add(null) should return argument null exception.")]
        public async void OpenSourceRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceRepository(Context);
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

        [Fact(DisplayName = "OpenSourceRepository.Edit(model) should return valid model.")]
        public async void OpenSourceRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceRepository(Context);
                var model = await rep.Edit(new OpenSource() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "OpenSourceRepository.Edit(null) should return argument null exception.")]
        public async void OpenSourceRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceRepository(Context);
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

        [Fact(DisplayName = "OpenSourceRepository.Remove(model) should return valid model.")]
        public async void OpenSourceRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceRepository(Context);
                var model = await rep.Remove(new OpenSource() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "OpenSourceRepository.Remove(null) should return argument null exception.")]
        public async void OpenSourceRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceRepository(Context);
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

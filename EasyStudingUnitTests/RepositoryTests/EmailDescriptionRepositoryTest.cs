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
    public class EmailDescriptionRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "EmailDescriptionRepository.GetAll() should return 5 objects.")]
        public void EmailDescriptionRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EmailDescriptionRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "EmailDescriptionRepository.Get(1) should return first object.")]
        public async void EmailDescriptionRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EmailDescriptionRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "EmailDescriptionRepository.Add(model) should return valid model.")]
        public async void EmailDescriptionRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EmailDescriptionRepository(Context);
                var model = await rep.Add(new EmailDescription() { Id = 6 });

                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "EmailDescriptionRepository.Add(null) should return argument null exception.")]
        public async void EmailDescriptionRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EmailDescriptionRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.Add(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EmailDescriptionRepository.Edit(model) should return valid model.")]
        public async void EmailDescriptionRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EmailDescriptionRepository(Context);
                var model = await rep.Edit(new EmailDescription() { Id = 5 });

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "EmailDescriptionRepository.Edit(null) should return argument null exception.")]
        public async void EmailDescriptionRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EmailDescriptionRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.Edit(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EmailDescriptionRepository.Edit(7) should return index out of range exception.")]
        public async void EmailDescriptionRepository_Edit_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EmailDescriptionRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.Edit(new EmailDescription() { Id = 7 }));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EmailDescriptionRepository.Remove(model) should return valid model.")]
        public async void EmailDescriptionRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EmailDescriptionRepository(Context);
                var model = await rep.Remove(5);

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "EmailDescriptionRepository.Remove(7) should return index out of range exception.")]
        public async void EmailDescriptionRepository_Remove_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EmailDescriptionRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.Remove(7));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }
    }
}

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
    public class EducationUserDescriptionRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "EducationUserDescriptionRepository.GetAll() should return 5 objects.")]
        public void EducationUserDescriptionRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationUserDescriptionRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "EducationUserDescriptionRepository.Get(1) should return first object.")]
        public async void EducationUserDescriptionRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationUserDescriptionRepository(Context);
                var result = await rep.GetAsync(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "EducationUserDescriptionRepository.Add(model) should return valid model.")]
        public async void EducationUserDescriptionRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationUserDescriptionRepository(Context);
                var model = await rep.AddAsync(new EducationUserDescription() { Id = 6 });

                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "EducationUserDescriptionRepository.Add(null) should return argument null exception.")]
        public async void EducationUserDescriptionRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationUserDescriptionRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.AddAsync(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EducationUserDescriptionRepository.Edit(model) should return valid model.")]
        public async void EducationUserDescriptionRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationUserDescriptionRepository(Context);
                var model = await rep.EditAsync(new EducationUserDescription() { Id = 5 });

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "EducationUserDescriptionRepository.Edit(null) should return argument null exception.")]
        public async void EducationUserDescriptionRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationUserDescriptionRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.EditAsync(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EducationUserDescriptionRepository.Edit(7) should return index out of range exception.")]
        public async void EducationUserDescriptionRepository_Edit_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationUserDescriptionRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.EditAsync(new EducationUserDescription() { Id = 7 }));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EducationUserDescriptionRepository.Remove(model) should return valid model.")]
        public async void EducationUserDescriptionRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationUserDescriptionRepository(Context);
                var model = await rep.RemoveAsync(5);

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "EducationUserDescriptionRepository.Remove(7) should return index out of range exception.")]
        public async void EducationUserDescriptionRepository_Remove_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationUserDescriptionRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.RemoveAsync(7));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }
    }
}

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
    public class EducationRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "EducationRepository.GetAll() should return 5 objects.")]
        public void EducationRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "EducationRepository.Get(1) should return first object.")]
        public async void EducationRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationRepository(Context);
                var result = await rep.GetAsync(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "EducationRepository.Add(model) should return valid model.")]
        public async void EducationRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationRepository(Context);
                var model = await rep.AddAsync(new Education() { Id = 6 });

                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "EducationRepository.Add(null) should return argument null exception.")]
        public async void EducationRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.AddAsync(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EducationRepository.Edit(model) should return valid model.")]
        public async void EducationRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationRepository(Context);
                var model = await rep.EditAsync(new Education() { Id = 5 });

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "EducationRepository.Edit(null) should return argument null exception.")]
        public async void EducationRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.EditAsync(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EducationRepository.Edit(7) should return index out of range exception.")]
        public async void EducationRepository_Edit_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.EditAsync(new Education() { Id = 7 }));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EducationRepository.Remove(model) should return valid model.")]
        public async void EducationRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationRepository(Context);
                var model = await rep.RemoveAsync(5);

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "EducationRepository.Remove(7) should return index out of range exception.")]
        public async void EducationRepository_Remove_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.RemoveAsync(7));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }
    }
}

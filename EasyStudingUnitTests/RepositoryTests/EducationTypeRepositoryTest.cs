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
    public class EducationTypeRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "EducationTypeRepository.GetAll() should return 2 objects.")]
        public void EducationTypeRepository_GetAll_should_return_2_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationTypeRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(2, result.Count());
            }
        }

        [Fact(DisplayName = "EducationTypeRepository.Get(1) should return first object.")]
        public async void EducationTypeRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationTypeRepository(Context);
                var result = await rep.GetAsync(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "EducationTypeRepository.Add(model) should return valid model.")]
        public async void EducationTypeRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationTypeRepository(Context);
                var model = await rep.AddAsync(new EducationType() { Id = 3 });

                Assert.Equal(3, model.Id);
            }
        }

        [Fact(DisplayName = "EducationTypeRepository.Add(null) should return argument null exception.")]
        public async void EducationTypeRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationTypeRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.AddAsync(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EducationTypeRepository.Edit(model) should return valid model.")]
        public async void EducationTypeRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationTypeRepository(Context);
                var model = await rep.EditAsync(new EducationType() { Id = 2 });

                Assert.Equal(2, model.Id);
            }
        }

        [Fact(DisplayName = "EducationTypeRepository.Edit(null) should return argument null exception.")]
        public async void EducationTypeRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationTypeRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.EditAsync(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EducationTypeRepository.Edit(7) should return index out of range exception.")]
        public async void EducationTypeRepository_Edit_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationTypeRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.EditAsync(new EducationType() { Id = 7 }));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }

        [Fact(DisplayName = "EducationTypeRepository.Remove(model) should return valid model.")]
        public async void EducationTypeRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationTypeRepository(Context);
                var model = await rep.RemoveAsync(2);

                Assert.Equal(2, model.Id);
            }
        }

        [Fact(DisplayName = "EducationTypeRepository.Remove(7) should return index out of range exception.")]
        public async void EducationTypeRepository_Remove_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new EducationTypeRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.RemoveAsync(7));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }
    }
}

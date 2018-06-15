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
    public class CostRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "CostRepository.GetAll() should return 2 objects.")]
        public void CostRepository_GetAll_should_return_2_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CostRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(2, result.Count());
            }
        }

        [Fact(DisplayName = "CostRepository.Get(1) should return first object.")]
        public async void CostRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CostRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "CostRepository.Add(model) should return valid model.")]
        public async void CostRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CostRepository(Context);
                var model = await rep.Add(new Cost() { Id = 3 });

                Assert.Equal(3, model.Id);
            }
        }

        [Fact(DisplayName = "CostRepository.Add(null) should return argument null exception.")]
        public async void CostRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CostRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.Add(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "CostRepository.Edit(model) should return valid model.")]
        public async void CostRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CostRepository(Context);
                var model = await rep.Edit(new Cost() { Id = 2 });

                Assert.Equal(2, model.Id);
            }
        }

        [Fact(DisplayName = "CostRepository.Edit(null) should return argument null exception.")]
        public async void CostRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CostRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.Edit(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "CostRepository.Edit(7) should return index out of range exception.")]
        public async void CostRepository_Edit_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CostRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.Edit(new Cost() { Id = 7 }));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }

        [Fact(DisplayName = "CostRepository.Remove(model) should return valid model.")]
        public async void CostRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CostRepository(Context);
                var model = await rep.Remove(2);

                Assert.Equal(2, model.Id);
            }
        }

        [Fact(DisplayName = "CostRepository.Remove(7) should return index out of range exception.")]
        public async void CostRepository_Remove_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new CostRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.Remove(7));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }
    }
}

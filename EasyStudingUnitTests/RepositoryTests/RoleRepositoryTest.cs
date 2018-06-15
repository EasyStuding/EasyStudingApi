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
    public class RoleRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "RoleRepository.GetAll() should return 3 objects.")]
        public void RoleRepository_GetAll_should_return_3_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new RoleRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(3, result.Count());
            }
        }

        [Fact(DisplayName = "RoleRepository.Get(1) should return first object.")]
        public async void RoleRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new RoleRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "RoleRepository.Add(model) should return valid model.")]
        public async void RoleRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new RoleRepository(Context);
                var model = await rep.Add(new Role() { Id = 4 });

                Assert.Equal(4, model.Id);
            }
        }

        [Fact(DisplayName = "RoleRepository.Add(null) should return argument null exception.")]
        public async void RoleRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new RoleRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.Add(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "RoleRepository.Edit(model) should return valid model.")]
        public async void RoleRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new RoleRepository(Context);
                var model = await rep.Edit(new Role() { Id = 3 });

                Assert.Equal(3, model.Id);
            }
        }

        [Fact(DisplayName = "RoleRepository.Edit(null) should return argument null exception.")]
        public async void RoleRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new RoleRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.Edit(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "RoleRepository.Edit(7) should return index out of range exception.")]
        public async void RoleRepository_Edit_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new RoleRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.Edit(new Role() { Id = 7 }));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }

        [Fact(DisplayName = "RoleRepository.Remove(model) should return valid model.")]
        public async void RoleRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new RoleRepository(Context);
                var model = await rep.Remove(new Role() { Id = 3 });

                Assert.Equal(3, model.Id);
            }
        }

        [Fact(DisplayName = "RoleRepository.Remove(null) should return argument null exception.")]
        public async void RoleRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new RoleRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.Remove(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "RoleRepository.Remove(7) should return index out of range exception.")]
        public async void RoleRepository_Remove_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new RoleRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.Remove(new Role() { Id = 7 }));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }
    }
}

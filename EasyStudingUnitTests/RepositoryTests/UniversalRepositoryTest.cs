using EasyStudingRepositories.DbContext;
using EasyStudingRepositories.Repositories;
using EasyStudingModels.Models;
using EasyStudingUnitTests.TestData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;


namespace EasyStudingUnitTests.RepositoryTests
{
    public class UniversalRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "UniversalRepository.GetAll() should return 5 objects.")]
        public void UniversalRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UniversalRepository<Country>(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "UniversalRepository.Get(1) should return first object.")]
        public async void UniversalRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UniversalRepository<Country>(Context);
                var result = await rep.GetAsync(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "UniversalRepository.Add(model) should return valid model.")]
        public async void UniversalRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UniversalRepository<Country>(Context);
                var model = await rep.AddAsync(new Country() { Id = 6 });

                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "UniversalRepository.Add(null) should return argument null exception.")]
        public async void UniversalRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UniversalRepository<Country>(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.AddAsync(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "UniversalRepository.Edit(model) should return valid model.")]
        public async void UniversalRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UniversalRepository<Country>(Context);
                var model = await rep.EditAsync(new Country() { Id = 5 });

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "UniversalRepository.Edit(null) should return argument null exception.")]
        public async void UniversalRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UniversalRepository<Country>(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.EditAsync(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "UniversalRepository.Edit(7) should return ArgumentNullException.")]
        public async void UniversalRepository_Edit_7_should_return_ArgumentNullExceptionn()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UniversalRepository<Country>(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.EditAsync(new Country() { Id = 7 }));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "UniversalRepository.Remove(model) should return valid model.")]
        public async void UniversalRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UniversalRepository<Country>(Context);
                var model = await rep.RemoveAsync(5);

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "UniversalRepository.Remove(7) should return ArgumentNullException.")]
        public async void UniversalRepository_Remove_7_should_return_ArgumentNullException()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UniversalRepository<Country>(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.RemoveAsync(7));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }
    }
}

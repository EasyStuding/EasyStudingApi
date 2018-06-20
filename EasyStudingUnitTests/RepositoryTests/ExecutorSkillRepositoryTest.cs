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
    public class ExecutorSkillRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "ExecutorSkillRepository.GetAll() should return 5 objects.")]
        public void ExecutorSkillRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ExecutorSkillRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "ExecutorSkillRepository.Get(1) should return first object.")]
        public async void ExecutorSkillRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ExecutorSkillRepository(Context);
                var result = await rep.GetAsync(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "ExecutorSkillRepository.Add(model) should return valid model.")]
        public async void ExecutorSkillRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ExecutorSkillRepository(Context);
                var model = await rep.AddAsync(new ExecutorSkill() { Id = 6 });

                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "ExecutorSkillRepository.Add(null) should return argument null exception.")]
        public async void ExecutorSkillRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ExecutorSkillRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.AddAsync(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorSkillRepository.Edit(model) should return valid model.")]
        public async void ExecutorSkillRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ExecutorSkillRepository(Context);
                var model = await rep.EditAsync(new ExecutorSkill() { Id = 5 });

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "ExecutorSkillRepository.Edit(null) should return argument null exception.")]
        public async void ExecutorSkillRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ExecutorSkillRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.EditAsync(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorSkillRepository.Edit(7) should return index out of range exception.")]
        public async void ExecutorSkillRepository_Edit_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ExecutorSkillRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.EditAsync(new ExecutorSkill() { Id = 7 }));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }

        [Fact(DisplayName = "ExecutorSkillRepository.Remove(model) should return valid model.")]
        public async void ExecutorSkillRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ExecutorSkillRepository(Context);
                var model = await rep.RemoveAsync(5);

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "ExecutorSkillRepository.Remove(7) should return index out of range exception.")]
        public async void ExecutorSkillRepository_Remove_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new ExecutorSkillRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.RemoveAsync(7));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }
    }
}

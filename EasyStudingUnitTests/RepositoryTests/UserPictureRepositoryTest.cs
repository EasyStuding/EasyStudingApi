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
    public class UserPictureRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "UserPictureRepository.GetAll() should return 5 objects.")]
        public void UserPictureRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserPictureRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "UserPictureRepository.Get(1) should return first object.")]
        public async void UserPictureRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserPictureRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "UserPictureRepository.Add(model) should return valid model.")]
        public async void UserPictureRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserPictureRepository(Context);
                var model = await rep.Add(new UserPicture() { Id = 6 });

                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "UserPictureRepository.Add(null) should return argument null exception.")]
        public async void UserPictureRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserPictureRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.Add(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "UserPictureRepository.Edit(model) should return valid model.")]
        public async void UserPictureRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserPictureRepository(Context);
                var model = await rep.Edit(new UserPicture() { Id = 5 });

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "UserPictureRepository.Edit(null) should return argument null exception.")]
        public async void UserPictureRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserPictureRepository(Context);
                var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await rep.Edit(null));

                Assert.Equal(typeof(ArgumentNullException), ex.GetType());
            }
        }

        [Fact(DisplayName = "UserPictureRepository.Edit(7) should return index out of range exception.")]
        public async void UserPictureRepository_Edit_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserPictureRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.Edit(new UserPicture() { Id = 7 }));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }

        [Fact(DisplayName = "UserPictureRepository.Remove(model) should return valid model.")]
        public async void UserPictureRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserPictureRepository(Context);
                var model = await rep.Remove(5);

                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "UserPictureRepository.Remove(7) should return index out of range exception.")]
        public async void UserPictureRepository_Remove_7_should_return_index_out_of_range_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new UserPictureRepository(Context);
                var ex = await Assert.ThrowsAsync<IndexOutOfRangeException>(async () => await rep.Remove(7));

                Assert.Equal(typeof(IndexOutOfRangeException), ex.GetType());
            }
        }
    }
}

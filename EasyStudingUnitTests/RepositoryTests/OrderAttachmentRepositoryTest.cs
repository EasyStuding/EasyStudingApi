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
    public class OrderAttachmentRepositoryTest
    {
        private EasyStudingContext Context;

        public OrderAttachmentRepositoryTest()
        {
            Context = new TestDbContext().Context;
        }

        [Fact(DisplayName = "OrderAttachmentRepository.GetAll() should return 5 objects.")]
        public async void OrderAttachmentRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderAttachmentRepository(Context);
                var result = await rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "OrderAttachmentRepository.Get(1) should return first object.")]
        public async void OrderAttachmentRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderAttachmentRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "OrderAttachmentRepository.Add(model) should return valid model.")]
        public async void OrderAttachmentRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderAttachmentRepository(Context);
                var model = await rep.Add(new OrderAttachment() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "OrderAttachmentRepository.Add(null) should return argument null exception.")]
        public async void OrderAttachmentRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderAttachmentRepository(Context);
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

        [Fact(DisplayName = "OrderAttachmentRepository.Edit(model) should return valid model.")]
        public async void OrderAttachmentRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderAttachmentRepository(Context);
                var model = await rep.Edit(new OrderAttachment() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "OrderAttachmentRepository.Edit(null) should return argument null exception.")]
        public async void OrderAttachmentRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderAttachmentRepository(Context);
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

        [Fact(DisplayName = "OrderAttachmentRepository.Remove(model) should return valid model.")]
        public async void OrderAttachmentRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderAttachmentRepository(Context);
                var model = await rep.Remove(new OrderAttachment() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "OrderAttachmentRepository.Remove(null) should return argument null exception.")]
        public async void OrderAttachmentRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OrderAttachmentRepository(Context);
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

﻿using EasyStudingRepositories.DbContext;
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
    public class OpenSourceAttachmentRepositoryTest
    {
        private EasyStudingContext Context;

        [Fact(DisplayName = "OpenSourceAttachmentRepository.GetAll() should return 5 objects.")]
        public void OpenSourceAttachmentRepository_GetAll_should_return_5_objects()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceAttachmentRepository(Context);
                var result = rep.GetAll();

                Assert.Equal(5, result.Count());
            }
        }

        [Fact(DisplayName = "OpenSourceAttachmentRepository.Get(1) should return first object.")]
        public async void OpenSourceAttachmentRepository_Get_1_should_return_first_object()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceAttachmentRepository(Context);
                var result = await rep.Get(1);

                Assert.Equal(1, result.Id);
            }
        }

        [Fact(DisplayName = "OpenSourceAttachmentRepository.Add(model) should return valid model.")]
        public async void OpenSourceAttachmentRepository_Add_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceAttachmentRepository(Context);
                var model = await rep.Add(new OpenSourceAttachment() { Id = 6 });
                Assert.Equal(6, model.Id);
            }
        }

        [Fact(DisplayName = "OpenSourceAttachmentRepository.Add(null) should return argument null exception.")]
        public async void OpenSourceAttachmentRepository_Add_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceAttachmentRepository(Context);
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

        [Fact(DisplayName = "OpenSourceAttachmentRepository.Edit(model) should return valid model.")]
        public async void OpenSourceAttachmentRepository_Edit_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceAttachmentRepository(Context);
                var model = await rep.Edit(new OpenSourceAttachment() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "OpenSourceAttachmentRepository.Edit(null) should return argument null exception.")]
        public async void OpenSourceAttachmentRepository_Edit_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceAttachmentRepository(Context);
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

        [Fact(DisplayName = "OpenSourceAttachmentRepository.Remove(model) should return valid model.")]
        public async void OpenSourceAttachmentRepository_Remove_model_should_return_valid_model()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceAttachmentRepository(Context);
                var model = await rep.Remove(new OpenSourceAttachment() { Id = 5 });
                Assert.Equal(5, model.Id);
            }
        }

        [Fact(DisplayName = "OpenSourceAttachmentRepository.Remove(null) should return argument null exception.")]
        public async void OpenSourceAttachmentRepository_Remove_null_should_return_argument_null_exception()
        {
            using (Context = new TestDbContext().Context)
            {
                var rep = new OpenSourceAttachmentRepository(Context);
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
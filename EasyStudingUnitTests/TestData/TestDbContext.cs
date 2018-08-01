using System;
using EasyStudingRepositories.DbContext;
using EasyStudingModels.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyStudingUnitTests.TestData
{
    public class TestDbContext
    {
        public EasyStudingContext Context;

        public TestDbContext()
        {
            var options = new DbContextOptionsBuilder<EasyStudingContext>()
                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
                  .Options;

            Context = new EasyStudingContext(options);

			CreateTestDataInDatabase();
        }

		private void CreateTestDataInDatabase()
		{
            CreateSkills();
        }

        private void CreateSkills()
        {
            Context.Skills.Add(new Skill() { Id = 1, Name = "USA" });
            Context.Skills.Add(new Skill() { Id = 2, Name = "Belarus" });
            Context.Skills.Add(new Skill() { Id = 3, Name = "Russia" });
            Context.Skills.Add(new Skill() { Id = 4, Name = "China" });
            Context.Skills.Add(new Skill() { Id = 5, Name = "UK" });

            Context.SaveChanges();
        }
    }
}

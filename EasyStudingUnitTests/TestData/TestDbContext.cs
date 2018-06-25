using System;
using System.Collections.Generic;
using System.Text;
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
            CreateCountries();
        }

        private void CreateCountries()
        {
            Context.Countries.Add(new Country() { Id = 1, Name = "USA", CreationDate = DateTime.Now });
            Context.Countries.Add(new Country() { Id = 2, Name = "Belarus", CreationDate = DateTime.Now });
            Context.Countries.Add(new Country() { Id = 3, Name = "Russia", CreationDate = DateTime.Now });
            Context.Countries.Add(new Country() { Id = 4, Name = "China", CreationDate = DateTime.Now });
            Context.Countries.Add(new Country() { Id = 5, Name = "UK", CreationDate = DateTime.Now });

            Context.SaveChanges();
        }
    }
}

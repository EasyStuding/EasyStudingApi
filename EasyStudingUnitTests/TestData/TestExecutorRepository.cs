using EasyStudingInterfaces.Repositories;
using EasyStudingModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingUnitTests.TestData
{
    public class TestExecutorRepository : IExecutorRepository
    {
        public async Task<IQueryable<Order>> GetOrders(string education, string country, string region, string city, long currentUserId)
        {
            return new[]
            {
                new Order(),
                new Order(),
                new Order(),
                new Order(),
                new Order()
            }.AsQueryable();
        }

        public async Task<Order> GetOrder(long id, long currentUserId)
        {
            return new Order()
            {
                Id = 1,
                CustomerId = 1,
                ExecutorId = 2,
                Description = "desc",
                InProgress = true,
                IsClosedByCustomer = false,
                IsClosedByExecutor = false,
                IsCompleted = false,
                Title = "title"
            };
        }

        public async Task<Order> GetTheRightsToPerformOrder(long id, long currentUserId)
        {
            return new Order()
            {
                Id = 1,
                CustomerId = 1,
                ExecutorId = 2,
                Description = "desc",
                InProgress = false,
                IsClosedByCustomer = false,
                IsClosedByExecutor = false,
                IsCompleted = false,
                Title = "title"
            };
        }

        public async Task<Order> CloseOrder(long id, long currentUserId)
        {
            return new Order()
            {
                Id = 1,
                CustomerId = 1,
                ExecutorId = 2,
                Description = "desc",
                InProgress = true,
                IsClosedByCustomer = false,
                IsClosedByExecutor = true,
                IsCompleted = false,
                Title = "title"
            };
        }

        public async Task<Skill> AddSkill(long id, long currentUserId)
        {
            return new Skill
            {
                Id = 1,
                Name = "SQL"
            };
        }

        public async Task<Skill> RemoveSkill(long id, long currentUserId)
        {
            return new Skill
            {
                Id = 1,
                Name = "SQL"
            };
        }
    }
}

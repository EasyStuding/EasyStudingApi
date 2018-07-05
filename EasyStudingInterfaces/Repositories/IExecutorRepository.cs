﻿using EasyStudingModels.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Repositories
{
    public interface IExecutorRepository
    {
        Task<IQueryable<Order>> GetOrders(string education, string country, string region, string city, long currentUserId);

        Task<Order> GetOrder(long id, long currentUserId);

        Task<Order> GetTheRightsToPerformOrder(long id, long currentUserId);

        Task<Order> CloseOrder(long id, long currentUserId);

        Task<Skill> AddSkill(long id, long currentUserId);

        Task<Skill> RemoveSkill(long id, long currentUserId);
    }
}

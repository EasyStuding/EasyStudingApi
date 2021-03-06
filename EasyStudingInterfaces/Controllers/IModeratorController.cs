﻿using EasyStudingModels.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Controllers
{
    public interface IModeratorController
    {
        Task<User> GrantRights(long userId, string permisions);

        Task<User> BanUser(long id);

        Task<User> RemoveBanOfUser(long id);

        Task<OrderToReturn> CloseOrder(long id);

        IQueryable<OrderToReturn> GetOrders(string education, string country, string region, string city, string skills);

        Task<OrderToReturn> GetOrder(long id);

        Task<FileResult> GetLogs(string date);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.Models;
using System.IO;
using EasyStudingModels.Extensions;
using Microsoft.AspNetCore.Authorization;
using EasyStudingModels;

namespace EasyStudingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Moderator/[action]")]
    [Authorize(Roles = Defines.Roles.ADMIN + "," + Defines.Roles.MODERATOR)]
    public class ModeratorController : Controller, IModeratorController
    {
        private readonly IModeratorService _service;

        public ModeratorController(IModeratorService service)
        {
            _service = service;
        }

        [HttpPost]
        // /api/moderator/BanUser
        public async Task<User> BanUser(long id)
        {
            return await _service.BanUser(id);
        }

        [HttpDelete]
        // /api/moderator/RemoveBanOfUser
        public async Task<User> RemoveBanOfUser(long id)
        {
            return await _service.RemoveBanOfUser(id);
        }

        [HttpPost]
        // /api/moderator/CloseOrder
        public async Task<Order> CloseOrder(long id)
        {
            return await _service.CloseOrder(id);
        }

        [HttpGet]
        // /api/moderator/GetOrders
        public IQueryable<Order> GetOrders(string education, string country, string region, string city)
        {
            return _service.GetOrders(education, country, region, city);
        }

        [HttpGet]
        // /api/moderator/GetOrder
        public async Task<Order> GetOrder(long id)
        {
            return await _service.GetOrder(id);
        }

        [HttpGet]
        // /api/moderator/GetLogs
        public async Task<FileResult> GetLogs(string date)
        {
            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot", date + "_log.txt");

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;

            var logs = File(memory, path.GetContentType(), Path.GetFileName(path));

            return logs;
        }
    }
}
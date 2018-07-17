using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingModels.Models;
using System.IO;
using EasyStudingModels.Extensions;
using Microsoft.AspNetCore.Authorization;
using EasyStudingModels;
using EasyStudingRepositories.DbContext;

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

        [Authorize(Roles = Defines.Roles.ADMIN)]
        [HttpPut]
        // /api/moderator/GrantModeratorRights
        public async Task<User> GrantRights(long userId, string permisions)
        {
            return await _service.GrantRights(userId, permisions);
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
        public async Task<OrderToReturn> CloseOrder(long id)
        {
            return await _service.CloseOrder(id);
        }

        [HttpGet]
        // /api/moderator/GetOrders
        public IQueryable<OrderToReturn> GetOrders(string education, string country, string region, string city, string skills)
        {
            return _service.GetOrders(education, country, region, city, skills);
        }

        [HttpGet]
        // /api/moderator/GetOrder
        public async Task<OrderToReturn> GetOrder(long id)
        {
            return await _service.GetOrder(id);
        }

        [HttpGet]
        // /api/moderator/GetLogs
        public async Task<FileResult> GetLogs(string date)
        {
            try
            {
                var path = Path.Combine(
                               Directory.GetCurrentDirectory(),
                               Defines.FileFolders.FolderPathes[Defines.FileFolders.LOGS_FOLDER], date + "_log.txt");

                var memory = new MemoryStream();

                using (var stream = FileStorage.GetFileStream(path, Defines.FileFolders.LOGS_FOLDER))
                {
                    await stream.CopyToAsync(memory);
                }

                memory.Position = 0;

                return File(memory, path.GetContentType(), Path.GetFileName(path));
            }
            catch
            {
                throw new ArgumentNullException();
            }
        }
    }
}
using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request.
    public class ExecutorService: IExecutorService
    {
        //TODO: initialize repositories;

        public async Task<IQueryable<ApiOrderDetailsModel>> GetOrderDetailsModels(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        public async Task<ApiOrderDetailsModel> GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        public async Task<ApiOrderDetailsModel> GetTheRightsToPerformOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiOrderDetailsModel> StartExecuteOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<ApiOrderDetailsModel> CloseOrder(long id)
        {
            throw new Exception();
        }

        public async Task<Skill> AddSkill(long id, long currentUserId)
        {
            throw new Exception();
        }

        public async Task<Skill> RemoveSkill(long id, long currentUserId)
        {
            throw new Exception();
        }
    }
}

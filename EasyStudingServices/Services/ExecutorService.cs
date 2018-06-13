using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingModels.ApiModels;
using EasyStudingModels.DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyStudingServices.Services
{
    //currentUserId - current user, who send request.
    public class ExecutorService: IExecutorService
    {
        //TODO: initialize repositories;

        public IQueryable<ApiOrderDetailsModel> GetOrderDetailsModels(ApiEducationModel education, City city)
        {
            throw new Exception();
        }

        public ApiOrderDetailsModel GetApiOrderDetailsModel(long id)
        {
            throw new Exception();
        }

        public ApiOrderDetailsModel GetTheRightsToPerformOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        public ApiOrderDetailsModel StartExecuteOrder(long id, long currentUserId)
        {
            throw new Exception();
        }

        public ApiOrderDetailsModel CloseOrder(long id)
        {
            throw new Exception();
        }

        public Skill AddSkill(long id, long currentUserId)
        {
            throw new Exception();
        }

        public Skill RemoveSkill(long id, long currentUserId)
        {
            throw new Exception();
        }
    }
}

using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingRepositories.Repositories
{
    public class OpenSourceAttachmentRepository: IRepository<OpenSourceAttachment>
    {
        private readonly EasyStudingContext Context;

        public OpenSourceAttachmentRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<OpenSourceAttachment> GetAll()
        {
            throw new Exception();
        }

        public async Task<OpenSourceAttachment> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<OpenSourceAttachment> AddAsync(OpenSourceAttachment param)
        {
            throw new Exception();
        }

        public async Task<OpenSourceAttachment> EditAsync(OpenSourceAttachment param)
        {
            throw new Exception();
        }

        public async Task<OpenSourceAttachment> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

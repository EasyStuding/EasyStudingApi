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

        public async Task<OpenSourceAttachment> Get(long id)
        {
            throw new Exception();
        }

        public async Task<OpenSourceAttachment> Add(OpenSourceAttachment param)
        {
            throw new Exception();
        }

        public async Task<OpenSourceAttachment> Edit(OpenSourceAttachment param)
        {
            throw new Exception();
        }

        public async Task<OpenSourceAttachment> Remove(long id)
        {
            throw new Exception();
        }
    }
}

using EasyStudingModels.DbContextModels;
using EasyStudingRepositories.DbContext;
using EasyStudingInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public OpenSourceAttachment Get(long id)
        {
            throw new Exception();
        }

        public OpenSourceAttachment Add(OpenSourceAttachment param)
        {
            throw new Exception();
        }

        public OpenSourceAttachment Edit(OpenSourceAttachment param)
        {
            throw new Exception();
        }

        public OpenSourceAttachment Remove(OpenSourceAttachment param)
        {
            throw new Exception();
        }
    }
}

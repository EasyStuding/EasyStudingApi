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
    public class AttachmentRepository: IRepository<Attachment>
    {
        private readonly EasyStudingContext Context;

        public AttachmentRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<Attachment> GetAll()
        {
            throw new Exception();
        }

        public async Task<Attachment> GetAsync(long id)
        {
            throw new Exception();
        }

        public async Task<Attachment> AddAsync(Attachment param)
        {
            throw new Exception();
        }

        public async Task<Attachment> EditAsync(Attachment param)
        {
            throw new Exception();
        }

        public async Task<Attachment> RemoveAsync(long id)
        {
            throw new Exception();
        }
    }
}

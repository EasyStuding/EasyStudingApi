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
    public class EmailDescriptionRepository: IRepository<EmailDescription>
    {
        private readonly EasyStudingContext Context;

        public EmailDescriptionRepository(EasyStudingContext context)
        {
            Context = context;
        }

        public IQueryable<EmailDescription> GetAll()
        {
            throw new Exception();
        }

        public async Task<EmailDescription> Get(long id)
        {
            throw new Exception();
        }

        public async Task<EmailDescription> Add(EmailDescription param)
        {
            throw new Exception();
        }

        public async Task<EmailDescription> Edit(EmailDescription param)
        {
            throw new Exception();
        }

        public async Task<EmailDescription> Remove(EmailDescription param)
        {
            throw new Exception();
        }
    }
}

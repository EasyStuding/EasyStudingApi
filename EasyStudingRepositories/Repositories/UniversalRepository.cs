using EasyStudingInterfaces.Repositories;
using EasyStudingInterfaces.Services;
using EasyStudingModels;
using EasyStudingRepositories.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingRepositories.Repositories
{
    public class UniversalRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity<TEntity>
    {
        private DbSet<TEntity> _dbSet;
        private EasyStudingContext _context;

        public UniversalRepository(EasyStudingContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public async Task<TEntity> GetAsync(long id)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(e => e.Id == id);


            if(entity == null)
            {
                throw new IndexOutOfRangeException();
            }

            return entity;
        }

        public async Task<TEntity> AddAsync(TEntity param)
        {
            if (param == null)
            {
                throw new ArgumentNullException();
            }

            await _dbSet.AddAsync(param);

            await _context.SaveChangesAsync();

            return await GetAll().LastOrDefaultAsync();
        }

        public async Task<TEntity> EditAsync(TEntity param)
        {
            if (param == null)
            {
                throw new ArgumentNullException();
            }

            var entity = await GetAsync(param.Id);

            entity.Edit(param);

            await _context.SaveChangesAsync();

            return await GetAsync(param.Id);
        }

        public async Task<TEntity> RemoveAsync(long id)
        {
            var entity = await GetAsync(id);

            _dbSet.Remove(entity);

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}

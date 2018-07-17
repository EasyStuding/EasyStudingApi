using EasyStudingInterfaces.Repositories;
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
        private readonly DbSet<TEntity> _dbSet;
        private readonly EasyStudingContext _context;

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
            return await _dbSet.FindAsync(id)
                ?? throw new ArgumentNullException();
        }

        public async Task<TEntity> AddAsync(TEntity param)
        {
            param = param
                ?? throw new ArgumentNullException();

            await _dbSet.AddAsync(param);

            await _context.SaveChangesAsync();

            return param;
        }

        public async Task<TEntity> EditAsync(TEntity param)
        {
            param = param
                ?? throw new ArgumentNullException();

            var entity = await GetAsync(param.Id);

            entity.Edit(param);

            await _context.SaveChangesAsync();

            return entity;
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

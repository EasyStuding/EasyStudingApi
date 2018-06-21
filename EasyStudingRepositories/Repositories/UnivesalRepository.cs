using EasyStudingInterfaces.Services;
using EasyStudingModels;
using EasyStudingRepositories.DbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingRepositories.Repositories
{
    public class UnivesalRepository<TEntity>
        where TEntity :  class , IEntity
    {
        private DbSet<TEntity> _dbSet;
        private  IErrorHandler _errorHandler;
        private  EasyStudingContext _context;

        public UnivesalRepository(DbSet<TEntity> dbSet, EasyStudingContext context, IErrorHandler errorHandler)
        {
            _dbSet = dbSet;
            _errorHandler = errorHandler;
            _context = context;
        }
        public async Task<TEntity> GetAsync(long id)
        {
            var cityModel = await _dbSet.FirstOrDefaultAsync(city => city.Id == id);

            _errorHandler.CheckIndexOutOfRangeException(cityModel);

            return cityModel;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            _errorHandler.CheckObjectOfNull(entity);

            await _dbSet.AddAsync(entity);

            await _context.SaveChangesAsync();

            return _dbSet.LastOrDefault();
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

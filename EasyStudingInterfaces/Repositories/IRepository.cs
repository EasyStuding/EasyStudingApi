using EasyStudingModels;
using System.Linq;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Repositories
{
    public interface IRepository<T>
        where T : class, IEntity<T>
    {
        IQueryable<T> GetAll();

        Task<T> GetAsync(long id);

        Task<T> AddAsync(T param);

        Task<T> EditAsync(T param);

        Task<T> RemoveAsync(long id);
    }
}

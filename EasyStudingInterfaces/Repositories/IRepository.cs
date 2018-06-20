using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStudingInterfaces.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();

        Task<T> GetAsync(long id);

        Task<T> AddAsync(T param);

        Task<T> EditAsync(T param);

        Task<T> RemoveAsync(long id);
    }
}

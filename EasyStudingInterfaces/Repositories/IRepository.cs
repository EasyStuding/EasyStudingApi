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

        Task<T> Get(long id);

        Task<T> Add(T param);

        Task<T> Edit(T param);

        Task<T> Remove(long id);
    }
}

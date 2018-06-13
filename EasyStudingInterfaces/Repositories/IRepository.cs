using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyStudingInterfaces.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();

        T Get(long id);

        T Add(T param);

        T Edit(T param);

        T Remove(T param);
    }
}

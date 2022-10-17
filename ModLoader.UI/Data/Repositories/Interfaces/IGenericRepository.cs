
using System;
using System.Collections.Generic;

namespace ModLoader.UI.Data.Repositories
{
    public interface IGenericRepository<T>
    {
        void CreateOrSkip(T item);
        T Find(int id);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Func<T, bool> predicate);
        void Remove(T item);
        void Update(T item);
    }
}


using System;
using System.Collections.Generic;

namespace ModLoader.Data.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void CreateOrSkip(TEntity item);
        TEntity Find(int id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}

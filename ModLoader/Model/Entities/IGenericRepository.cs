﻿
using ModLoader.Model.Entities.Base;
using System;
using System.Collections.Generic;

namespace EntityCRUDExample
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void CreateOrDefault(TEntity item);
        TEntity Find(int id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}
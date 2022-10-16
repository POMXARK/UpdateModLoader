
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace ModLoader.Data.Repositories
{   /// <summary>
    /// https://metanit.com/sharp/entityframework/3.13.php
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>

    public class EFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext _context;
        DbSet<TEntity> _dbSet;

        public EFGenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public EFGenericRepository()
        {
            _context = new Context();
            _dbSet = _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Include(includeProperties).ToList();
        }

        public IEnumerable<TEntity> GetWithInclude(Func<TEntity, bool> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = Include(includeProperties);
            return query.Where(predicate).ToList();
        }

        private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbSet.AsNoTracking();
            return includeProperties
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public TEntity Find(int id)
        {
            return _dbSet.Find(id);
        }

        public Games FindGames(string name)
        { return _context.Set<Games>().Where(Games => Games.Name == name).FirstOrDefault(); }

        public ModCollection FindModCollection(string name)
        { return _context.Set<ModCollection>().Where(ModCollection => ModCollection.Name == name).FirstOrDefault(); }

        public Pack FindModPack(string name)
        { return _context.Set<Pack>().Where(Pack => Pack.Name == name).FirstOrDefault(); }

        public void CreateOrSkip(TEntity item)
        {
            _dbSet.Add(item);
            try { _context.SaveChanges(); }
            catch (Exception) { }
        }

        public void CreateOrSkip(List<TEntity> items)
        {
            _dbSet.AddRange(items);
            try { _context.SaveChanges(); }
            catch (Exception) { }
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(List<TEntity> items)
        {
            _context.Entry(items).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(TEntity item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
        public void Remove(List<TEntity> items)
        {
            _dbSet.RemoveRange(items);
            _context.SaveChanges();
        }
    }
}
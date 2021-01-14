using Domain.Entities;
using Domain.Interfaces;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repository.GenericRepository
{
    public class GenericRepository<TEntity> 
        : IGenericRepository<TEntity> where TEntity : BaseEntitie
    {
        private readonly MainContext _mainContext;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(MainContext dbContext)
        {
            _mainContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public TEntity GetById(Guid id)
        {
            return Query().FirstOrDefault(entity => entity.Id == id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Query().ToList();
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);
            _mainContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _mainContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entityToDelete = _dbSet.Find(id);
            _dbSet.Remove(entityToDelete);
            _mainContext.SaveChanges();
        }

        protected IQueryable<TEntity> Query() => _dbSet.AsNoTracking();
    }
}

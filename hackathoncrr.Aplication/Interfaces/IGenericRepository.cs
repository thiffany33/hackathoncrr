using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Aplication.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntitie
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
    }
}

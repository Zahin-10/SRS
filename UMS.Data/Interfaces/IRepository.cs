using System.Collections.Generic;

namespace UMS.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity: class
    {
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Get<TKey>(TKey id);
    }
}
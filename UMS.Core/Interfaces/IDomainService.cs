using System.Collections.Generic;

namespace UMS.Core.Interfaces
{
    public interface IDomainService<TEntity>: IService where TEntity : class
    {
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Get<TKey>(TKey id);
    }
}

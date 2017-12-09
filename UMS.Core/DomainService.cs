using System.Collections.Generic;
using UMS.Core.Interfaces;
using UMS.Data;
using UMS.Data.Interfaces;

namespace UMS.Core
{
    public abstract class DomainService<TEntity>: IDomainService<TEntity> where TEntity: class
    {
        protected internal IRepository<TEntity> repository;

        public DomainService()
        {
            repository = new RepositoryFactory().Create<TEntity>();
        }

        public virtual bool Insert(TEntity entity)
        {
            return repository.Insert(entity);
        }

        public virtual bool Update(TEntity entity)
        {
            return repository.Update(entity);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public virtual TEntity Get<Tkey>(Tkey id)
        {
            return repository.Get(id);
        }
    }
}

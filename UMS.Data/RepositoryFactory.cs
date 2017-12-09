using System;
using System.Collections.Generic;
using UMS.Data.Interfaces;
using UMS.Entity;

namespace UMS.Data
{
    public class RepositoryFactory
    {
        private readonly IDictionary<Type, Type> repositories = new Dictionary<Type, Type>();

        public RepositoryFactory()
        {
            repositories.Add(typeof(Department), typeof(DepartmentRepository));
            repositories.Add(typeof(Student), typeof(StudentRepository));
            repositories.Add(typeof(Course), typeof(CourseRepository));
            repositories.Add(typeof(Item), typeof(ItemRepository));
            repositories.Add(typeof(Category), typeof(CategoryRepository));
            repositories.Add(typeof(Promotion), typeof(PromotionRepository));
        }

        public IRepository<TEntity> Create<TEntity>() where TEntity: class
        {
            Type type = repositories[typeof(TEntity)];
            return Activator.CreateInstance(type) as IRepository<TEntity>;
        }
    }
}

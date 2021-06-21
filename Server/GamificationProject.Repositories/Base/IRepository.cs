using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GamificationProject.Interfaces
{
    public interface IRepository<T> where T : Base
    {
        IQueryable<T> Query();
        IEnumerable<T> Read(Expression<Func<T, bool>> query);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Detach(T entity);
        void SaveChanges();
    }
}

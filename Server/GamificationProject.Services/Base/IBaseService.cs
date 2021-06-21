using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GamificationProject.Interfaces
{
    public interface IBaseService<T> where T : Base
    {
        IEnumerable<T> All();
        IEnumerable<T> Get(Expression<Func<T, bool>> query);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GamificationProject.Interfaces
{
    public interface ISimpleDetailedService<T> : ISimpleService<T> where T : Simple
    {
        IEnumerable<T> AllDetailed();
        T GetDetailed(int id);
        IEnumerable<T> GetDetailed(Expression<Func<T, bool>> query);
    }
}

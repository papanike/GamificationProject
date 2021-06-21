using GamificationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GamificationProject.Server.Services
{
    public abstract class SimpleDetailedService<Entity> : SimpleService<Entity>, ISimpleDetailedService<Entity>
         where Entity : Simple, new()
    {
        public SimpleDetailedService(IRepository<Entity> repository, ISessionProvider sessionProvider) : base(repository, sessionProvider)
        {
        }

        public virtual IEnumerable<Entity> AllDetailed()
        {
            return ApplyIncludes(_Repository.Query()).ToList();
        }

        public virtual Entity GetDetailed(int id)
        {
            return ApplyIncludes(_Repository.Query()).Where(x => x.Id == id).SingleOrDefault();
        }

        public virtual IEnumerable<Entity> GetDetailed(Expression<Func<Entity, bool>> query)
        {
            return ApplyIncludes(_Repository.Query()).Where(query).ToList();
        }

        protected virtual IQueryable<Entity> ApplyIncludes(IQueryable<Entity> query)
        {
            return query;
        }
    }
}

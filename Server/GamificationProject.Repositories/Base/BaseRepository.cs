using GamificationProject.Data;
using GamificationProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GamificationProject.Repositories
{
    public abstract class BaseRepository<Entity> : IRepository<Entity>
            where Entity : Base
    {
        protected readonly DbContext _Context;
        protected readonly DbSet<Entity> _BaseQuery;

        public BaseRepository(DbContext context)
        {
            _Context = context;
            _BaseQuery = context.Set<Entity>();
        }

        public virtual IQueryable<Entity> Query()
        {
            return _BaseQuery.AsNoTracking().AsQueryable();
        }

        public virtual IEnumerable<Entity> Read(Expression<Func<Entity, bool>> query)
        {
            try
            {
                return _BaseQuery.AsNoTracking().Where(query).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Create(Entity entity)
        {
            try
            {
                _Context.Entry(entity).State = EntityState.Added;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Update(Entity entity)
        {
            try
            {
                _Context.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Delete(Entity entity)
        {
            try
            {
                _Context.Entry(entity).State = EntityState.Deleted;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Detach(Entity entity)
        {
            try
            {
                _Context.Entry(entity).State = EntityState.Detached;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveChanges()
        {
            try
            {
                _Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

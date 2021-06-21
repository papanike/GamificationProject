using GamificationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GamificationProject.Server.Services
{
    public abstract class BaseService<Entity> : IBaseService<Entity>
         where Entity : Base
    {
        protected readonly IRepository<Entity> _Repository;
        protected readonly ISession _Session;

        public BaseService(IRepository<Entity> repository, ISessionProvider sessionProvider)
        {
            _Repository = repository;
            _Session = sessionProvider.Session;
        }

        public virtual IEnumerable<Entity> All()
        {
            return FilterData(_Repository.Read(x => true));
        }

        public virtual IEnumerable<Entity> Get(Expression<Func<Entity, bool>> query)
        {
            return FilterData(_Repository.Read(query));
        }

        public virtual void Insert(Entity entity)
        {

            _Repository.Create(entity);
            try
            {
                _Repository.SaveChanges();
            }
            catch
            {
                _Repository.Detach(entity);
                throw;
            }
        }

        public virtual void Update(Entity entity)
        {
            _Repository.Update(entity);
            try
            {
                _Repository.SaveChanges();
            }
            catch
            {
                _Repository.Detach(entity);
                throw;
            }
        }

        public virtual void Delete(Entity entity)
        {
            _Repository.Delete(entity);
            _Repository.SaveChanges();
        }

        protected virtual IEnumerable<Entity> FilterData(IEnumerable<Entity> entities)
        {
            return entities;
        }
    }
}

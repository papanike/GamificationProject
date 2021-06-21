using GamificationProject.Interfaces;
using System.Linq;

namespace GamificationProject.Server.Services
{
    public abstract class SimpleService<Entity> : BaseService<Entity>, ISimpleService<Entity>
         where Entity : Simple, new()
    {

        public SimpleService(IRepository<Entity> repository, ISessionProvider sessionProvider) : base(repository, sessionProvider)
        {
        }

        public virtual Entity Get(int id)
        {
            return _Repository.Read(x => x.Id == id).SingleOrDefault();
        }

        public virtual void Delete(int id)
        {
            _Repository.Delete(new Entity() { Id = id });
            _Repository.SaveChanges();
        }
    }
}

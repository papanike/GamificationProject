using GamificationProject.Data;
using GamificationProject.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamificationProject.Repositories
{

    public abstract class SimpleRepository<Entity> : BaseRepository<Entity>, IRepository<Entity>
        where Entity : Simple
    {
        protected SimpleRepository(DbContext context) : base(context)
        {
        }
    }
}

using GamificationProject.Data;
using GamificationProject.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GamificationProject.Server.Repositories
{
    public class UserRepository : SimpleRepository<User>
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}

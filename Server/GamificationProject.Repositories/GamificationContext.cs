using GamificationProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamificationProject.Repositories
{
    public class GamificationContext : DbContext
    {
        public GamificationContext(DbContextOptions<GamificationContext> options) : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSessionHistory> UserSessionHistories { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
    }
}

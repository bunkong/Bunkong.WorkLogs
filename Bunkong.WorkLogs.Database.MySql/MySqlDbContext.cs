using Bunkong.WorkLogs.Database.Schema;
using Microsoft.EntityFrameworkCore;
using System;

namespace Bunkong.WorkLogs.Database.MySql
{
    public class MySqlDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=localhost;Database=Bunkong.WorkLogs;Uid=root;Password=***");
        }

        public DbSet<WorkLog> WorkLogs { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<UserRoles> UserRoles { get; set; }
    }
}

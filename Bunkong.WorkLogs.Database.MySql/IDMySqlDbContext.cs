using Bunkong.WorkLogs.Database.Schema;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bunkong.WorkLogs.Database.MySql
{
    public class IDMySqlDbContext : DbContext
    {
        public IDMySqlDbContext(DbContextOptions<IDMySqlDbContext> options)
          : base(options)
        { }

        public DbSet<WorkLog> WorkLogs { get; set; }

        public DbSet<Users> Users { get; set; } 

        public DbSet<Roles> Roles { get; set; }

        public DbSet<UserRoles> UserRoles { get; set; }
    }
}

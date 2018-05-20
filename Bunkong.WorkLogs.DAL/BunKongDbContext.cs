using Microsoft.EntityFrameworkCore;
using System;

namespace Bunkong.WorkLogs.DAL
{
    /// <summary>
    /// OnConfiguring dbContext
    /// Tip 
    /// This approach does not lend itself to testing, unless the tests target the full database.
    /// </summary>
    public class BunKongDbContext : DbContext
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Bunkong.WorkLogs;Trusted_Connection=True;ConnectRetryCount=0");
        }

        public DbSet<WorkLog> WorkLogs { get; set; } 

        public DbSet<TestTwoDbContextMigrateTable> TestTwoDbContextMigrateTable { get; set; }
    }
}

using Bunkong.WorkLogs.Database.Schema;
using Microsoft.EntityFrameworkCore;
using System;

namespace Bunkong.WorkLogs.Database.MSSQL
{
    public class MSSQLDbContext: DbContext
    {
        /// <summary>
        /// OnConfiguring dbContext
        /// Tip 
        /// This approach does not lend itself to testing, unless the tests target the full database.
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Bunkong.WorkLogs;Trusted_Connection=True;ConnectRetryCount=0");
        }

        public DbSet<WorkLog> WorkLogs { get; set; }
    }
}

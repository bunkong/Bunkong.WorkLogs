using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bunkong.WorkLogs.DAL
{
    public class InjectDependencyBunkongDbContext : DbContext
    {
        public InjectDependencyBunkongDbContext(DbContextOptions<InjectDependencyBunkongDbContext> options)
           : base(options)
        { }

        public DbSet<WorkLog> WorkLogs { get; set; }

        public DbSet<TestTwoDbContextMigrateTable> TestTwoDbContextMigrateTable { get; set; }
    }
}

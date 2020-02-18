using Jessidatasyncer.Domain;
using Microsoft.EntityFrameworkCore;

namespace Jessidatasyncer.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
        public DbSet<MsSqlPrimaryCache> MsSqlIds { get; set; }
        public DbSet<MySqlPrimaryCache> MySqlIds { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSQLite(@"DataSource=mydatabase.db");
        }
    }
}
using Jessidatasyncer.Domain;
using Microsoft.EntityFrameworkCore;

namespace Jessidatasyncer.Persistence
{
    public class AppDbContext : DbContext
    {
        private DbSet<Record> Records { get; set; }
        private DbSet<> MsSqlIdCache { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSQLite(@"DataSource=mydatabase.db");
        }
    }
}
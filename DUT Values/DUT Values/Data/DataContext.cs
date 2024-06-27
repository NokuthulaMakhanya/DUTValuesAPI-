using Microsoft.EntityFrameworkCore;
using DUT_Values.Models;

namespace DUT_Values.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DbSet<DUTValue> DUTValues { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DUTValues;Trusted_Connection=true;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DUTValue>().HasData(
                new DUTValue { DUTValueId = 1, DUTValueName = "Transparency" },
                new DUTValue { DUTValueId = 2, DUTValueName = "Honesty" },
                new DUTValue { DUTValueId = 3, DUTValueName = "Integrity" },
                new DUTValue { DUTValueId = 4, DUTValueName = "Respect" },
                new DUTValue { DUTValueId = 5, DUTValueName = "Accountability" }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace CafeReserve
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.Migrate();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=cafereserve_s.db");
        }
    }
}
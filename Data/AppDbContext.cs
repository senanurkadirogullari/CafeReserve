using CafeReserve.Business;
using Microsoft.EntityFrameworkCore;

namespace CafeReserve.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.Migrate();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=cafereserve_s.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "sena", Password = "12345" }
            );
        }
    }
}
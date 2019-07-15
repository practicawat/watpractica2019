using Microsoft.EntityFrameworkCore;
using CarRentalApp.Models;

namespace CarRentalApp.Context
{
    public class CarDbContext:DbContext
    {
        public CarDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car() { CarId = 1, Name = "John", Designation = "Developer", CompanyName = "XYZ Inc", Price = 30000 },
                new Car() { CarId = 2, Name = "Chris", Designation = "Manager", CompanyName = "ABC Inc", Price = 50000 },
                new Car() { CarId = 3, Name = "Mukesh", Designation = "Consultant", CompanyName = "XYZ Inc", Price = 20000 });
        }
    }
}

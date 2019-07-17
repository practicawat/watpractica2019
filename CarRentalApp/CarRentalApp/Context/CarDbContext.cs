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
       
      
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }
    }
}

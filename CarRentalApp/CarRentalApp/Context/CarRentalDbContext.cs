﻿using Microsoft.EntityFrameworkCore;
using CarRentalApp.Models;

namespace CarRentalApp.Context
{
    public class CarRentalDbContext:DbContext
    {
        public CarRentalDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<InfoUser> InfoUsers { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //empty
        }

    }
}

﻿// <auto-generated />
using CarRentalApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRentalApp.Migrations
{
    [DbContext(typeof(CarDbContext))]
    [Migration("20190709074124_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarRentalApp.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<string>("Designation");

                    b.Property<string>("Name");

                    b.Property<float>("Price");

                    b.HasKey("CarId");

                    b.ToTable("Cars");

                    b.HasData(
                        new { CarId = 1, CompanyName = "XYZ Inc", Designation = "Developer", Name = "John", Price = 30000f },
                        new { CarId = 2, CompanyName = "ABC Inc", Designation = "Manager", Name = "Chris", Price = 50000f },
                        new { CarId = 3, CompanyName = "XYZ Inc", Designation = "Consultant", Name = "Mukesh", Price = 20000f }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}

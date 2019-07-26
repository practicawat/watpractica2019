﻿// <auto-generated />
using System;
using CarRentalApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRentalApp.Migrations
{
    [DbContext(typeof(CarRentalDbContext))]
    [Migration("20190725144649_NewMigration")]
    partial class NewMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarRentalApp.Models.Car", b =>
                {
                    b.Property<string>("LicensePlate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("CurrentCity");

                    b.Property<bool>("HasAutomaticGearbox");

                    b.Property<string>("ImgCars");

                    b.Property<string>("Model");

                    b.Property<short>("NrOfDoors");

                    b.Property<short>("NrOfSeats");

                    b.Property<float>("PricePerDay");

                    b.HasKey("LicensePlate");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarRentalApp.Models.City", b =>
                {
                    b.Property<int>("IDCity")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.Property<string>("CountyName");

                    b.HasKey("IDCity");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CarRentalApp.Models.Images", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Img");

                    b.Property<string>("RelatedCarLicensePlate");

                    b.HasKey("Id");

                    b.HasIndex("RelatedCarLicensePlate");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("CarRentalApp.Models.InfoUser", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("PhoneNumber");

                    b.HasKey("IdUser");

                    b.ToTable("InfoUsers");
                });

            modelBuilder.Entity("CarRentalApp.Models.Rentals", b =>
                {
                    b.Property<int>("RentalsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityEndId");

                    b.Property<int>("CityStartId");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("InfoUserId");

                    b.Property<string>("RegistrationNumber");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("RentalsId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("CarRentalApp.Models.SearchedCar", b =>
                {
                    b.Property<string>("IdSearchedCar")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsChecked");

                    b.Property<string>("concatenatePickup");

                    b.Property<string>("concatenateReturn");

                    b.Property<string>("selectedCity");

                    b.Property<string>("selectedPickupHour");

                    b.Property<string>("selectedPickupPeriod");

                    b.Property<string>("selectedReturnHour");

                    b.Property<string>("selectedReturnPeriod");

                    b.HasKey("IdSearchedCar");

                    b.ToTable("SearchedCars");
                });

            modelBuilder.Entity("CarRentalApp.Models.Images", b =>
                {
                    b.HasOne("CarRentalApp.Models.Car", "RelatedCar")
                        .WithMany("ImageList")
                        .HasForeignKey("RelatedCarLicensePlate");
                });
#pragma warning restore 612, 618
        }
    }
}

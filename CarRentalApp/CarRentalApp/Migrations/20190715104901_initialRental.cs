using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class initialRental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    RentalsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    InfoUserId = table.Column<int>(nullable: false),
                    CityStartId = table.Column<int>(nullable: false),
                    CityEndId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.RentalsId);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CompanyName", "Designation", "Name", "Price" },
                values: new object[] { 1, "XYZ Inc", "Developer", "John", 30000f });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CompanyName", "Designation", "Name", "Price" },
                values: new object[] { 2, "ABC Inc", "Manager", "Chris", 50000f });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CompanyName", "Designation", "Name", "Price" },
                values: new object[] { 3, "XYZ Inc", "Consultant", "Mukesh", 20000f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Rentals");
        }
    }
}

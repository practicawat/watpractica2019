using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Cars",
                newName: "PricePerDay");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cars",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "Designation",
                table: "Cars",
                newName: "Brand");

            migrationBuilder.AddColumn<string>(
                name: "LicensePlate",
                table: "Cars",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasAutomaticGearbox",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<short>(
                name: "NrOfDoors",
                table: "Cars",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "NrOfSeats",
                table: "Cars",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "LicensePlate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "LicensePlate",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasAutomaticGearbox",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "NrOfDoors",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "NrOfSeats",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "PricePerDay",
                table: "Cars",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Cars",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "Cars",
                newName: "Designation");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Cars",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "CarId");

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
    }
}

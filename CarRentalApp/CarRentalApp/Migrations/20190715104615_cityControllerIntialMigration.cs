using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class cityControllerIntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    IDCity = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(nullable: true),
                    CountyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.IDCity);
                });
        }

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "Cities");

        //    migrationBuilder.InsertData(
        //        table: "Cars",
        //        columns: new[] { "CarId", "CompanyName", "Designation", "Name", "Price" },
        //        values: new object[] { 1, "XYZ Inc", "Developer", "John", 30000f });

        //    migrationBuilder.InsertData(
        //        table: "Cars",
        //        columns: new[] { "CarId", "CompanyName", "Designation", "Name", "Price" },
        //        values: new object[] { 2, "ABC Inc", "Manager", "Chris", 50000f });

        //    migrationBuilder.InsertData(
        //        table: "Cars",
        //        columns: new[] { "CarId", "CompanyName", "Designation", "Name", "Price" },
        //        values: new object[] { 3, "XYZ Inc", "Consultant", "Mukesh", 20000f });
        //}
    }
}

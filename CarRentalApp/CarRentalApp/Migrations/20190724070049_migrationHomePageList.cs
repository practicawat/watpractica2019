using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class migrationHomePageList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SearchedCars",
                columns: table => new
                {
                    IdSearchedCar = table.Column<string>(nullable: false),
                    selectedCity = table.Column<string>(nullable: true),
                    selectedPickupHour = table.Column<string>(nullable: true),
                    selectedReturnHour = table.Column<string>(nullable: true),
                    selectedPickupPeriod = table.Column<string>(nullable: true),
                    selectedReturnPeriod = table.Column<string>(nullable: true),
                    concatenatePickup = table.Column<string>(nullable: true),
                    concatenateReturn = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchedCars", x => x.IdSearchedCar);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchedCars");
        }
    }
}

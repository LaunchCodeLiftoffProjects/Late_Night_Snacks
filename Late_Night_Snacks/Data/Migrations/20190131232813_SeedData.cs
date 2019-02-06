using Microsoft.EntityFrameworkCore.Migrations;

namespace Late_Night_Snacks.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "ID", "Description", "Name", "Price", "Quantity" },
                values: new object[] { -1, "Mouthwatering", "Ribs", 24.99m, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}

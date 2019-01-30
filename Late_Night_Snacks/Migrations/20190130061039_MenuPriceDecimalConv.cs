using Microsoft.EntityFrameworkCore.Migrations;

namespace Late_Night_Snacks.Migrations
{
    public partial class MenuPriceDecimalConv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Menus",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Menus",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}

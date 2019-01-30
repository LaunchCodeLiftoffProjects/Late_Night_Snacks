using Microsoft.EntityFrameworkCore.Migrations;

namespace Late_Night_Snacks.Migrations
{
    public partial class UpdateMenuItemQty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "Menus",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Qty",
                table: "Menus",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}

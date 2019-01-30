using Microsoft.EntityFrameworkCore.Migrations;

namespace Late_Night_Snacks.Migrations
{
    public partial class AddMenuItemQty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Qty",
                table: "Menus",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qty",
                table: "Menus");
        }
    }
}

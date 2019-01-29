using Microsoft.EntityFrameworkCore.Migrations;

namespace Late_Night_Snacks.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Menus",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Menus",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocker.Data.Migrations
{
    public partial class AddedFieldsToProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Products");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Data.Migrations
{
    public partial class updateFavoriteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Favorits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Favorits",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Favorits");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Favorits");
        }
    }
}

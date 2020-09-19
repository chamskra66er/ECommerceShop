using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Data.Migrations
{
    public partial class updateSubCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubCatalogId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCatalogId",
                table: "Products",
                column: "SubCatalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCatalogs_SubCatalogId",
                table: "Products",
                column: "SubCatalogId",
                principalTable: "SubCatalogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCatalogs_SubCatalogId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SubCatalogId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SubCatalogId",
                table: "Products");
        }
    }
}

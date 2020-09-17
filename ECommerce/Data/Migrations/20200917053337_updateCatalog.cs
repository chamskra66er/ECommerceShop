using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Data.Migrations
{
    public partial class updateCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SubCatalogs_CatalogId",
                table: "SubCatalogs",
                column: "CatalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCatalogs_Catalogs_CatalogId",
                table: "SubCatalogs",
                column: "CatalogId",
                principalTable: "Catalogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCatalogs_Catalogs_CatalogId",
                table: "SubCatalogs");

            migrationBuilder.DropIndex(
                name: "IX_SubCatalogs_CatalogId",
                table: "SubCatalogs");
        }
    }
}

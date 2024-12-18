using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotherStoreApi.Migrations
{
    /// <inheritdoc />
    public partial class modificationdeidparent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentCategorieId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ParentCategorieId",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentCategorieId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentCategorieId",
                table: "Categories",
                column: "ParentCategorieId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}

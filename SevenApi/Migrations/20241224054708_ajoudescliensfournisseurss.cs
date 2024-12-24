using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotherStoreApi.Migrations
{
    /// <inheritdoc />
    public partial class ajoudescliensfournisseurss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "LimiteDeCredit",
                table: "Tiers",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "LimiteDeCredit",
                table: "Tiers",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }
    }
}

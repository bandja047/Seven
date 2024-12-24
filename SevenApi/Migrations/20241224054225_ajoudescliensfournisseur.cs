using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotherStoreApi.Migrations
{
    /// <inheritdoc />
    public partial class ajoudescliensfournisseur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DealaiLivraison",
                table: "Tiers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Tiers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "LimiteDeCredit",
                table: "Tiers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProgrammeFidelite",
                table: "Tiers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DealaiLivraison",
                table: "Tiers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Tiers");

            migrationBuilder.DropColumn(
                name: "LimiteDeCredit",
                table: "Tiers");

            migrationBuilder.DropColumn(
                name: "ProgrammeFidelite",
                table: "Tiers");
        }
    }
}

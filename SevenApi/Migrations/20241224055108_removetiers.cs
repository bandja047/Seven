using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotherStoreApi.Migrations
{
    /// <inheritdoc />
    public partial class removetiers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tiers",
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

            migrationBuilder.RenameTable(
                name: "Tiers",
                newName: "Fournisseurs");

            migrationBuilder.AlterColumn<int>(
                name: "DealaiLivraison",
                table: "Fournisseurs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fournisseurs",
                table: "Fournisseurs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgrammeFidelite = table.Column<int>(type: "int", nullable: false),
                    LimiteDeCredit = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataVersion = table.Column<int>(type: "int", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quartier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodePostale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fournisseurs",
                table: "Fournisseurs");

            migrationBuilder.RenameTable(
                name: "Fournisseurs",
                newName: "Tiers");

            migrationBuilder.AlterColumn<int>(
                name: "DealaiLivraison",
                table: "Tiers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Tiers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "LimiteDeCredit",
                table: "Tiers",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProgrammeFidelite",
                table: "Tiers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tiers",
                table: "Tiers",
                column: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doacoes_Web.Migrations
{
    /// <inheritdoc />
    public partial class Addcolunastabeladoacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Doacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeMedida",
                table: "Doacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Doacoes");

            migrationBuilder.DropColumn(
                name: "UnidadeMedida",
                table: "Doacoes");
        }
    }
}

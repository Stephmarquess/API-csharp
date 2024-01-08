using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace agenciaGoTour.Migrations
{
    /// <inheritdoc />
    public partial class clienttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCliente = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "id", "CPF", "Email", "Endereco", "NomeCliente" },
                values: new object[,]
                {
                    { 1, "02519956356", "david@bowie.com", "Ocean Beach, San Francisco", "David Robert Jones" },
                    { 2, "15945578962", "sting@thepolice.com", "Dogpatch, San Francisco", "Gordon Matthew Thomas Sumner" },
                    { 3, "222145789623", "alan@cryptanalyst.com", "Bayside, Tierra Robada", "Alan Mathison Turing" },
                    { 4, "01578889623", "margaret@tothemoon.com", "Washington Street, Washington", "Margaret Heafield Hamilton" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace agenciaGoTour.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Destinos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 1,
                column: "Imagem",
                value: "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 2,
                column: "Imagem",
                value: "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 3,
                column: "Imagem",
                value: "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 4,
                column: "Imagem",
                value: "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Destinos");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace agenciaGoTour.Migrations
{
    /// <inheritdoc />
    public partial class addimagens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Descricao", "Imagem" },
                values: new object[] { "Litoral do estado do Ceará, Região Nordeste do país. Principal ponto turístico: Beach Park.", "https://www.alemdaenergia.engie.com.br/uploads/2020/06/aquiraz-cidade-inteligente.jpg" });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 2,
                column: "Descricao",
                value: "Litoral sudeste. Diversidade e beleza paisagística. Principal ponto turístico: Pão de Açúcar, Cristo Redentor.");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Descricao", "Imagem" },
                values: new object[] { "Serra Gaúcha. Beleza com ruas floridas, repletas. Arquitetura bávara. Ótimos para momentos a dois e em família. ", "https://media.gazetadopovo.com.br/2022/09/17194513/Gramado-tem-atrativos-o-ano-inteiro.-Vale-a-pena-conhecer-cada-pedaC3A7o-da-cidade-seja-qual-for-a-C3A9poca-da-sua-viagem.-960x540.jpg" });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Descricao", "Imagem" },
                values: new object[] { "Um dos lugares mais intensos e incríveis da Argentina. Lugares como impressionantes, lagos, arroios, rios de degelo e montanhas.", "https://escapemagazine.com.br/wp-content/uploads/2023/08/winter-night-esqui-em-bariloche.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Descricao", "Imagem" },
                values: new object[] { "Teste", "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg" });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 2,
                column: "Descricao",
                value: "Teste");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Descricao", "Imagem" },
                values: new object[] { "Teste", "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg" });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Descricao", "Imagem" },
                values: new object[] { "Teste", "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg" });
        }
    }
}

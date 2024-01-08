using System.ComponentModel.DataAnnotations.Schema;

namespace agenciaGoTour.Model
{
    public class Cliente
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("NomeCliente")]
        public string NomeCliente { get; set; } = string.Empty;

        [Column("CPF")]
        public string CPF { get; set; } = string.Empty;

        [Column("Email")]
        public string Email { get; set; } = string.Empty;

        [Column("Endereco")]
        public string Endereco { get; set; } = string.Empty;
    }
}

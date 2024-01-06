using System.ComponentModel.DataAnnotations.Schema;

namespace agenciaGoTour.Model
{

    [Table("Destinos")]
    public class Destinos
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("Descricao")]
        public string Descricao { get; set; } = string.Empty;


    }

}

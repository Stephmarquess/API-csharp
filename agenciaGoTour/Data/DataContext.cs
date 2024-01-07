
using agenciaGoTour.Model;
using Microsoft.EntityFrameworkCore;

namespace agenciaGoTour.Data
{

  public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Destinos> Destinos { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Destinos>().HasData(
                new Destinos { Id = 1, Nome = "Aquiraz", Descricao = "Litoral do estado do Ceará, Região Nordeste do país. Principal ponto turístico: Beach Park.", Imagem = "https://www.alemdaenergia.engie.com.br/uploads/2020/06/aquiraz-cidade-inteligente.jpg" },
                new Destinos { Id = 2, Nome = "Rio de Janeiro", Descricao = "Litoral sudeste. Diversidade e beleza paisagística. Principal ponto turístico: Pão de Açúcar, Cristo Redentor.", Imagem = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg" },
                new Destinos { Id = 3, Nome = "Gramado", Descricao = "Serra Gaúcha. Beleza com ruas floridas, repletas. Arquitetura bávara. Ótimos para momentos a dois e em família. ", Imagem = "https://media.gazetadopovo.com.br/2022/09/17194513/Gramado-tem-atrativos-o-ano-inteiro.-Vale-a-pena-conhecer-cada-pedaC3A7o-da-cidade-seja-qual-for-a-C3A9poca-da-sua-viagem.-960x540.jpg" },
                new Destinos { Id = 4, Nome = "Bariloche", Descricao = "Um dos lugares mais intensos e incríveis da Argentina. Lugares como impressionantes, lagos, arroios, rios de degelo e montanhas.", Imagem = "https://escapemagazine.com.br/wp-content/uploads/2023/08/winter-night-esqui-em-bariloche.jpg" }

            );
        }



    }



}


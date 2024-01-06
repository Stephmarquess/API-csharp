
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
                new Destinos { Id = 1, Nome = "Aquiraz", Descricao = "Teste" },
                new Destinos { Id = 2, Nome = "Rio de Janeiro", Descricao = "Teste" },
                new Destinos { Id = 3, Nome = "Gramado", Descricao = "Teste" },
                new Destinos { Id = 4, Nome = "Bariloche", Descricao = "Teste"}

            );
        }



    }



}


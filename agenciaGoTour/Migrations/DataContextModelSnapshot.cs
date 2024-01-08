﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using agenciaGoTour.Data;

#nullable disable

namespace agenciaGoTour.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("agenciaGoTour.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Endereco");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NomeCliente");

                    b.HasKey("Id");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "02519956356",
                            Email = "david@bowie.com",
                            Endereco = "Ocean Beach, San Francisco",
                            NomeCliente = "David Robert Jones"
                        },
                        new
                        {
                            Id = 2,
                            CPF = "15945578962",
                            Email = "sting@thepolice.com",
                            Endereco = "Dogpatch, San Francisco",
                            NomeCliente = "Gordon Matthew Thomas Sumner"
                        },
                        new
                        {
                            Id = 3,
                            CPF = "222145789623",
                            Email = "alan@cryptanalyst.com",
                            Endereco = "Bayside, Tierra Robada",
                            NomeCliente = "Alan Mathison Turing"
                        },
                        new
                        {
                            Id = 4,
                            CPF = "01578889623",
                            Email = "margaret@tothemoon.com",
                            Endereco = "Washington Street, Washington",
                            NomeCliente = "Margaret Heafield Hamilton"
                        });
                });

            modelBuilder.Entity("agenciaGoTour.Model.Destinos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Descricao");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Imagem");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Destinos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Litoral do estado do Ceará, Região Nordeste do país. Principal ponto turístico: Beach Park.",
                            Imagem = "https://www.alemdaenergia.engie.com.br/uploads/2020/06/aquiraz-cidade-inteligente.jpg",
                            Nome = "Aquiraz"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Litoral sudeste. Diversidade e beleza paisagística. Principal ponto turístico: Pão de Açúcar, Cristo Redentor.",
                            Imagem = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg",
                            Nome = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Serra Gaúcha. Beleza com ruas floridas, repletas. Arquitetura bávara. Ótimos para momentos a dois e em família. ",
                            Imagem = "https://media.gazetadopovo.com.br/2022/09/17194513/Gramado-tem-atrativos-o-ano-inteiro.-Vale-a-pena-conhecer-cada-pedaC3A7o-da-cidade-seja-qual-for-a-C3A9poca-da-sua-viagem.-960x540.jpg",
                            Nome = "Gramado"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Um dos lugares mais intensos e incríveis da Argentina. Lugares como impressionantes, lagos, arroios, rios de degelo e montanhas.",
                            Imagem = "https://escapemagazine.com.br/wp-content/uploads/2023/08/winter-night-esqui-em-bariloche.jpg",
                            Nome = "Bariloche"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using agenciaGoTour.Data;

#nullable disable

namespace agenciaGoTour.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240107012321_secondmigration")]
    partial class secondmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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
                            Descricao = "Teste",
                            Imagem = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg",
                            Nome = "Aquiraz"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Teste",
                            Imagem = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg",
                            Nome = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Teste",
                            Imagem = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg",
                            Nome = "Gramado"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Teste",
                            Imagem = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg",
                            Nome = "Bariloche"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
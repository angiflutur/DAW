﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proiect.Data;

#nullable disable

namespace proiect.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230902173757_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("proiect.Models.Actor", b =>
                {
                    b.Property<int>("IdActor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdActor"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeActor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdActor");

                    b.ToTable("Actori");
                });

            modelBuilder.Entity("proiect.Models.Actor_Film", b =>
                {
                    b.Property<int>("IdActor")
                        .HasColumnType("int");

                    b.Property<int>("IdFilm")
                        .HasColumnType("int");

                    b.HasKey("IdActor", "IdFilm");

                    b.HasIndex("IdFilm");

                    b.ToTable("Actori_Filme");
                });

            modelBuilder.Entity("proiect.Models.Cinema", b =>
                {
                    b.Property<int>("IdCinema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCinema"));

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeCinema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCinema");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("proiect.Models.Film", b =>
                {
                    b.Property<int>("IdFilm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFilm"));

                    b.Property<int>("CategorieFilm")
                        .HasColumnType("int");

                    b.Property<int>("IdCinema")
                        .HasColumnType("int");

                    b.Property<int>("IdProducator")
                        .HasColumnType("int");

                    b.Property<string>("Imagine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Pret")
                        .HasColumnType("float");

                    b.Property<string>("Titlu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFilm");

                    b.HasIndex("IdCinema");

                    b.HasIndex("IdProducator");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("proiect.Models.Producator", b =>
                {
                    b.Property<int>("IdProducator")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducator"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeProducator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProducator");

                    b.ToTable("Producatori");
                });

            modelBuilder.Entity("proiect.Models.Actor_Film", b =>
                {
                    b.HasOne("proiect.Models.Actor", "Actor")
                        .WithMany("Actori_Filme")
                        .HasForeignKey("IdActor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiect.Models.Film", "Film")
                        .WithMany("Actori_Filme")
                        .HasForeignKey("IdFilm")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("proiect.Models.Film", b =>
                {
                    b.HasOne("proiect.Models.Cinema", "Cinema")
                        .WithMany("Filme")
                        .HasForeignKey("IdCinema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiect.Models.Producator", "Producator")
                        .WithMany("Filme")
                        .HasForeignKey("IdProducator")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Producator");
                });

            modelBuilder.Entity("proiect.Models.Actor", b =>
                {
                    b.Navigation("Actori_Filme");
                });

            modelBuilder.Entity("proiect.Models.Cinema", b =>
                {
                    b.Navigation("Filme");
                });

            modelBuilder.Entity("proiect.Models.Film", b =>
                {
                    b.Navigation("Actori_Filme");
                });

            modelBuilder.Entity("proiect.Models.Producator", b =>
                {
                    b.Navigation("Filme");
                });
#pragma warning restore 612, 618
        }
    }
}

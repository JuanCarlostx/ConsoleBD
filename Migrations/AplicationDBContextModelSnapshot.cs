﻿// <auto-generated />
using Ejemplodeifelse2.Funciones;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ejemplodeifelse2.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    partial class AplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Ejemplodeifelse2.Entities.Ciudad", b =>
                {
                    b.Property<int>("PKCiudad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PKCiudad");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("Ejemplodeifelse2.Entities.Persona", b =>
                {
                    b.Property<int>("PKPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("FKCiudad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.HasKey("PKPersona");

                    b.HasIndex("FKCiudad");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Ejemplodeifelse2.Entities.Persona", b =>
                {
                    b.HasOne("Ejemplodeifelse2.Entities.Ciudad", "Ciudades")
                        .WithMany()
                        .HasForeignKey("FKCiudad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudades");
                });
#pragma warning restore 612, 618
        }
    }
}

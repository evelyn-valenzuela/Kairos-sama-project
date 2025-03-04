﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210925000609_AlterTables")]
    partial class AlterTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Veterinaria.App.Dominio.Atencion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExploracionClinica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotivoConsulta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pronostico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Atencion");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AtencionId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MascotaId")
                        .HasColumnType("int");

                    b.Property<int?>("TipoCitaId")
                        .HasColumnType("int");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AtencionId");

                    b.HasIndex("MascotaId");

                    b.HasIndex("TipoCitaId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Especie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Especie");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CuidadorId")
                        .HasColumnType("int");

                    b.Property<string>("DetalleCuidado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Esterilzado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<int?>("RazaId")
                        .HasColumnType("int");

                    b.Property<string>("Tamaño")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CuidadorId");

                    b.HasIndex("GeneroId");

                    b.HasIndex("RazaId");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Raza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EspecieId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EspecieId");

                    b.ToTable("Raza");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.TipoCita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoCita");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Cuidador", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.Persona");

                    b.Property<string>("TelefonoSecundario")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Cuidador");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.Persona");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Cita", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.Atencion", "Atencion")
                        .WithMany()
                        .HasForeignKey("AtencionId");

                    b.HasOne("Veterinaria.App.Dominio.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId");

                    b.HasOne("Veterinaria.App.Dominio.TipoCita", "TipoCita")
                        .WithMany()
                        .HasForeignKey("TipoCitaId");

                    b.HasOne("Veterinaria.App.Dominio.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("Atencion");

                    b.Navigation("Mascota");

                    b.Navigation("TipoCita");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Mascota", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.Cuidador", "Cuidador")
                        .WithMany()
                        .HasForeignKey("CuidadorId");

                    b.HasOne("Veterinaria.App.Dominio.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");

                    b.HasOne("Veterinaria.App.Dominio.Raza", "Raza")
                        .WithMany()
                        .HasForeignKey("RazaId");

                    b.Navigation("Cuidador");

                    b.Navigation("Genero");

                    b.Navigation("Raza");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Raza", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.Especie", "Especie")
                        .WithMany()
                        .HasForeignKey("EspecieId");

                    b.Navigation("Especie");
                });
#pragma warning restore 612, 618
        }
    }
}

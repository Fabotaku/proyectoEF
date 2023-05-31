﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyectoef;

#nullable disable

namespace vscode.Migrations
{
    [DbContext(typeof(TareasContext))]
    partial class TareasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("proyectoef.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("peso")
                        .HasColumnType("int");

                    b.HasKey("CategoriaID");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoriaID = new Guid("e8a90193-9f42-4348-a122-2aad81cb7741"),
                            Nombre = "Actividades Pendientes",
                            peso = 20
                        },
                        new
                        {
                            CategoriaID = new Guid("e8a90193-9f42-4348-a122-2aad81cb7742"),
                            Nombre = "Actividades Personales",
                            peso = 50
                        });
                });

            modelBuilder.Entity("proyectoef.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("int");

                    b.HasKey("TareaID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaID = new Guid("e8a90193-9f42-4348-a122-2aad81cb7743"),
                            CategoriaID = new Guid("e8a90193-9f42-4348-a122-2aad81cb7741"),
                            FechaCreacion = new DateTime(2023, 5, 30, 22, 54, 25, 662, DateTimeKind.Local).AddTicks(627),
                            Nombre = "Pago de servicios publicos",
                            PrioridadTarea = 1
                        },
                        new
                        {
                            TareaID = new Guid("e8a90193-9f42-4348-a122-2aad81cb7744"),
                            CategoriaID = new Guid("e8a90193-9f42-4348-a122-2aad81cb7742"),
                            FechaCreacion = new DateTime(2023, 5, 30, 22, 54, 25, 662, DateTimeKind.Local).AddTicks(692),
                            Nombre = "Terminar de ver pelicula",
                            PrioridadTarea = 2
                        });
                });

            modelBuilder.Entity("proyectoef.Models.Tarea", b =>
                {
                    b.HasOne("proyectoef.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("proyectoef.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
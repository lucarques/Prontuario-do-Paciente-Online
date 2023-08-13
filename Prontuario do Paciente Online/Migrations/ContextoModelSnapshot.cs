﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Prontuario_do_Paciente_Online.Models;

#nullable disable

namespace Prontuario_do_Paciente_Online.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Prontuario_do_Paciente_Online.Models.PacienteXAcompanhante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Bairro");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CPF");

                    b.Property<string>("CPFAcompanhante")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CPFAcompanhante");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Celular");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cidade");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Endereco");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Estado");

                    b.Property<string>("GrauParentesco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("GrauParentesco");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Motivo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.Property<string>("NomeAcompanhante")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NomeAcompanhante");

                    b.Property<int>("Numero")
                        .HasColumnType("integer")
                        .HasColumnName("Numero");

                    b.Property<char>("Sexo")
                        .HasColumnType("character(1)")
                        .HasColumnName("Sexo");

                    b.HasKey("Id");

                    b.ToTable("PacienteXAcompanhante");
                });
#pragma warning restore 612, 618
        }
    }
}

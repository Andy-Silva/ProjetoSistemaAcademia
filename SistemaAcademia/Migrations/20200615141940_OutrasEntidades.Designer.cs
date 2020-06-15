﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaAcademia.Data;

namespace SistemaAcademia.Migrations
{
    [DbContext(typeof(SistemaAcademiaContext))]
    [Migration("20200615141940_OutrasEntidades")]
    partial class OutrasEntidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SistemaAcademia.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<DateTime>("DataAniversario");

                    b.Property<int?>("DepartamentoId");

                    b.Property<string>("Nome");

                    b.Property<int?>("ProfessorId");

                    b.Property<int>("Total");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("SistemaAcademia.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("SistemaAcademia.Models.Ficha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlunoId");

                    b.Property<DateTime>("Data");

                    b.Property<DateTime>("Fim");

                    b.Property<DateTime>("Inicio");

                    b.Property<int?>("ProfessorId");

                    b.Property<int>("Status");

                    b.Property<int>("Total");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Ficha");
                });

            modelBuilder.Entity("SistemaAcademia.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAniversario");

                    b.Property<int?>("DepartamentoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("SistemaAcademia.Models.Aluno", b =>
                {
                    b.HasOne("SistemaAcademia.Models.Departamento", "Departamento")
                        .WithMany("Alunos")
                        .HasForeignKey("DepartamentoId");

                    b.HasOne("SistemaAcademia.Models.Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("ProfessorId");
                });

            modelBuilder.Entity("SistemaAcademia.Models.Ficha", b =>
                {
                    b.HasOne("SistemaAcademia.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId");

                    b.HasOne("SistemaAcademia.Models.Professor", "Professor")
                        .WithMany("Fichas")
                        .HasForeignKey("ProfessorId");
                });

            modelBuilder.Entity("SistemaAcademia.Models.Professor", b =>
                {
                    b.HasOne("SistemaAcademia.Models.Departamento", "Departamento")
                        .WithMany("Professores")
                        .HasForeignKey("DepartamentoId");
                });
#pragma warning restore 612, 618
        }
    }
}
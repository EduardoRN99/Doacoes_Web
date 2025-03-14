﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Doacoes_Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250314010548_Add colunas tabela doacoes")]
    partial class Addcolunastabeladoacoes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("Domain.Entities.Models.Doacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaAlimento")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataDoacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("DoadorEmpresaId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DoadorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusDoacao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UnidadeMedida")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DoadorEmpresaId");

                    b.HasIndex("DoadorId");

                    b.ToTable("Doacoes");
                });

            modelBuilder.Entity("Domain.Entities.Models.Doador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Complemento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("NumeroEndereco")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Doadores");
                });

            modelBuilder.Entity("Domain.Entities.Models.Doador_Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Complemento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("NumeroEndereco")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DoadoresEmpresa");
                });

            modelBuilder.Entity("Domain.Entities.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Entities.Models.Doacao", b =>
                {
                    b.HasOne("Domain.Entities.Models.Doador_Empresa", null)
                        .WithMany()
                        .HasForeignKey("DoadorEmpresaId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Domain.Entities.Models.Doador", "Doador")
                        .WithMany()
                        .HasForeignKey("DoadorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Doador");
                });
#pragma warning restore 612, 618
        }
    }
}

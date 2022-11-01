﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProdutosApi.Backend.Data;

#nullable disable

namespace ProdutosApi.Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221101034526_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProdutosApi.Backend.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataCriacao")
                        .HasMaxLength(60)
                        .HasColumnType("SmallDateTime")
                        .HasColumnName("DataCriacao");

                    b.Property<DateTime>("DataEdicao")
                        .HasMaxLength(60)
                        .HasColumnType("SmallDateTime")
                        .HasColumnName("DataEdicao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("Varchar(1000)")
                        .HasColumnName("Descricao");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Imagem");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("Titulo");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric(18,2)")
                        .HasColumnName("Valor");

                    b.HasKey("Id");

                    b.ToTable("Produtos", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

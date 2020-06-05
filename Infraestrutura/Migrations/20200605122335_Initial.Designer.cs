﻿// <auto-generated />
using System;
using Infraestrutura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infraestrutura.Migrations
{
    [DbContext(typeof(ArchContext))]
    [Migration("20200605122335_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Associados.Associado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Associados");
                });

            modelBuilder.Entity("Domain.Associados.Associado", b =>
                {
                    b.OwnsOne("Domain.Associados.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<Guid>("AssociadoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Complemento")
                                .HasColumnName("Complemento")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasColumnName("Logradouro")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Numero")
                                .ValueGeneratedOnAdd()
                                .HasColumnName("Numero")
                                .HasColumnType("int")
                                .HasDefaultValue(0);

                            b1.HasKey("AssociadoId");

                            b1.ToTable("Associados");

                            b1.WithOwner()
                                .HasForeignKey("AssociadoId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
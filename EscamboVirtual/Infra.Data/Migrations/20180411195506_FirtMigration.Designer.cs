﻿// <auto-generated />
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180411195506_FirtMigration")]
    partial class FirtMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PessoaId");

                    b.Property<string>("Resumo_Biografia");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Domain.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Domain.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cidade");

                    b.Property<string>("Pais");

                    b.Property<string>("Rua");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Domain.Models.Exemplar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnoCompra");

                    b.Property<int>("LivroId");

                    b.Property<int>("PessoaID");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.HasIndex("PessoaID");

                    b.ToTable("Exemplares");
                });

            modelBuilder.Entity("Domain.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Isbn");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("Domain.Models.LivroAutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AutorId");

                    b.Property<int>("LivroId");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("LivroId");

                    b.ToTable("LivrosAutores");
                });

            modelBuilder.Entity("Domain.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("Domain.Models.Troca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Trocas");
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PessoaId");

                    b.Property<string>("Senha");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Models.Autor", b =>
                {
                    b.HasOne("Domain.Models.Pessoa", "Pessoa")
                        .WithMany("Autores")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Models.Exemplar", b =>
                {
                    b.HasOne("Domain.Models.Livro", "Livro")
                        .WithMany("Exemplares")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.Pessoa", "Pessoa")
                        .WithMany("Exemplares")
                        .HasForeignKey("PessoaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Models.Livro", b =>
                {
                    b.HasOne("Domain.Models.Categoria", "Categoria")
                        .WithMany("Livros")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Models.LivroAutor", b =>
                {
                    b.HasOne("Domain.Models.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.Livro", "Livro")
                        .WithMany("Autores")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Models.Pessoa", b =>
                {
                    b.HasOne("Domain.Models.Endereco", "Endereco")
                        .WithMany("Pessoas")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.HasOne("Domain.Models.Pessoa", "Pessoa")
                        .WithMany("Ususarios")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
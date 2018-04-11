using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public IConfigurationRoot Configuration { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings

            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Exemplar> Exemplares { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<LivroAutor> LivrosAutores { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Troca> Trocas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
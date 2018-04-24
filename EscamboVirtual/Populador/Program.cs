using Domain.Models;
using Domain.Repositories;
using Infra.Data.Context;
using Infra.Data.Repositories;
using System;

namespace Populador
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _context = new DataContext();
            ICategoriaRepository _categoriaRepository = new CategoriaRepository(_context);
            var categoria = new Categoria()
            {
                Descricao = "Romance"
            };
            _categoriaRepository.Create(categoria);
        }
    }
}

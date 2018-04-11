using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Categoria : IEntity
    {
        public Categoria()
        {
            Livros = new HashSet<Livro>();
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}

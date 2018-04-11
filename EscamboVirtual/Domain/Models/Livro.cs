using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Livro : IEntity
    {
        public Livro()
        {
            Autores = new HashSet<LivroAutor>();
            Exemplares = new HashSet<Exemplar>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Isbn { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public ICollection<LivroAutor> Autores { get; set; }
        public ICollection<Exemplar> Exemplares { get; set; }
    }
}

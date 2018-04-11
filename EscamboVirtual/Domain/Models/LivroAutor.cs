using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class LivroAutor : IEntity
    {
        public int Id { get; set; }
        public int LivroId { get; set; }
        public int AutorId { get; set; }
        public virtual Livro Livro { get; set; }
        public virtual Autor Autor { get; set; }
    }
}

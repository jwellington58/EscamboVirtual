using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Autor : IEntity
    {
        public Autor()
        {
            Livros = new HashSet<LivroAutor>();
        }
        public int Id { get; set; }
        public string Resumo_Biografia { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public ICollection<LivroAutor> Livros { get; set; }
        
    }
}

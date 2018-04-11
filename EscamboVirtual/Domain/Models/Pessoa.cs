using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Pessoa : IEntity
    {
        public Pessoa()
        {
            Ususarios = new HashSet<Usuario>();
            Autores = new HashSet<Autor>();
            Exemplares = new HashSet<Exemplar>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public ICollection<Usuario> Ususarios { get; set; }
        public ICollection<Autor> Autores { get; set; }
        public ICollection<Exemplar> Exemplares { get; set; }
    }
}

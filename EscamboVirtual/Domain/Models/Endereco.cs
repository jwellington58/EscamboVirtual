using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Endereco : IEntity
    {
        public Endereco()
        {
            Pessoas = new HashSet<Pessoa>();
        }
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Pais { get; set; }
        public ICollection<Pessoa> Pessoas { get; set; }
    }
}

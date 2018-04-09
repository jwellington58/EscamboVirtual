using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Exemplar : IEntity
    {
        public int Id { get; set; }
        public int AnoCompra { get; set; }
        public int PessoaID { get; set; }
        public int LivroId { get; set; }
        public Pessoa Pessoa { get; set; }
        public Livro Livro { get; set; }
    
    }
}

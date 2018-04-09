using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Usuario : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}

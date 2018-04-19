using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Impl
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        protected EnderecoService(IEnderecoRepository repository) : base(repository)
        {
        }
    }
}

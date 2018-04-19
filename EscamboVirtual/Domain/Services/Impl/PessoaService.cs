using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Impl
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        protected PessoaService(IPessoaRepository repository) : base(repository)
        {
        }
    }
}

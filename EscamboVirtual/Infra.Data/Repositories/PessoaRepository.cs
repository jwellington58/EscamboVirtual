using Domain.Models;
using Domain.Repositories;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}

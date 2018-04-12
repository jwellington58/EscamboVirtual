using Domain.Models;
using Domain.Repositories;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Repositories
{
    public class TrocaRepository : RepositoryBase<Troca>, ITrocaRepository
    {
        public TrocaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}

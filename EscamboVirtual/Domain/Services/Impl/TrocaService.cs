using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Impl
{
    public class TrocaService : ServiceBase<Troca>, ITrocaService
    {
        protected TrocaService(ITrocaRepository repository) : base(repository)
        {
        }
    }
}

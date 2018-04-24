using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Impl
{
    public class ExemplarService : ServiceBase<Exemplar>, IExemplarService
    {
        public ExemplarService(IExemplarRepositoy repository) : base(repository)
        {
        }
    }
}

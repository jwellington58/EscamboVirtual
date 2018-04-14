using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Impl
{
    public class AutorService : ServiceBase<Autor>, IAutorService
    {
        public AutorService(IRepositoryBase<Autor> repository) : base(repository)
        {
        }
    }
}

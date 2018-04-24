using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Services.Impl
{
    public class LivroAutorService : ServiceBase<LivroAutor>, ILivroAutorService
    {
        public LivroAutorService(ILivroAutorRepository repository) : base(repository)
        {
        }
    }
}

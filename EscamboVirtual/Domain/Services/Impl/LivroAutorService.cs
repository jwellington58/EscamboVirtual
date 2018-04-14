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
        protected LivroAutorService(IRepositoryBase<LivroAutor> repository) : base(repository)
        {
        }
    }
}

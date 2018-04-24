using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Impl
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        public LivroService(ILivroRepository repository) : base(repository)
        {
        }
    }
}

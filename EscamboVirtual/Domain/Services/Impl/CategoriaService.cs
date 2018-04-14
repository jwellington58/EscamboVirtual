using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Impl
{
    public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
    {
        protected CategoriaService(IRepositoryBase<Categoria> repository) : base(repository)
        {
        }
    }
}

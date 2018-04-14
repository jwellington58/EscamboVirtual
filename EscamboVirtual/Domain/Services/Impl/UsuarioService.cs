using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Impl
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        protected UsuarioService(IRepositoryBase<Usuario> repository) : base(repository)
        {
        }
    }
}

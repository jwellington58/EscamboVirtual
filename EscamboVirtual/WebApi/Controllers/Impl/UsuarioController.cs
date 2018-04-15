using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Impl
{
    public class UsuarioController : ControllerBase<Usuario>, IUsuarioController
    {
        public UsuarioController(IServiceBase<Usuario> service) : base(service)
        {
        }
    }
}

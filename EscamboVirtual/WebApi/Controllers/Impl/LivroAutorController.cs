using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Impl
{
    public class LivroAutorController : ControllerBase<LivroAutor>, ILivroAutorController
    {
        public LivroAutorController(IServiceBase<LivroAutor> service) : base(service)
        {
        }
    }
}

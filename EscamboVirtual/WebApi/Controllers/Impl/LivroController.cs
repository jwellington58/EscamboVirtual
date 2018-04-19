using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Impl
{
    public class LivroController : ControllerBase<Livro>, ILivroController
    {
        public LivroController(ILivroService service) : base(service)
        {
        }
    }
}

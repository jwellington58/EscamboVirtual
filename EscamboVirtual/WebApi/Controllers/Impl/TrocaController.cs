using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Impl
{
    public class TrocaController : ControllerBase<Troca>, ITrocaController
    {
        public TrocaController(ITrocaService service) : base(service)
        {
        }
    }
}

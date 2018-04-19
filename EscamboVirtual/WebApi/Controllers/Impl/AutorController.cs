using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Impl
{
    public class AutorController : ControllerBase<Autor>, IAutorController
    {
        public AutorController(IAutorService service) : base(service)
        {
        }
    }
}

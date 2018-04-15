﻿using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Impl
{
    public class EnderecoController : ControllerBase<Endereco>, IEnderecoController
    {
        public EnderecoController(IServiceBase<Endereco> service) : base(service)
        {
        }
    }
}

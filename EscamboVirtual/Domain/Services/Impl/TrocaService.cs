﻿using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Impl
{
    public class TrocaService : ServiceBase<Troca>, ITrocaService
    {
        public TrocaService(ITrocaRepository repository) : base(repository)
        {
        }
    }
}

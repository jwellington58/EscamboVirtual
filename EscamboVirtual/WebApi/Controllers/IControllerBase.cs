﻿using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    public interface IControllerBase<T> where T : class, IEntity
    {
       IActionResult GetAll();
       IActionResult Get(int id);
       IActionResult Create(T newObject);
       
       IActionResult Update(int id, T newObject);
       IActionResult Delete(int id);

    }
}

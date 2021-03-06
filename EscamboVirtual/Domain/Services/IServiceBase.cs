﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Services
{
    public interface IServiceBase<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();
        T Get(int id);
        //void Create(T entity, bool unSaveChanges);
        T Create(T etity);
        T Update(T entity, int id);
        void Delete(int id);
    }
}

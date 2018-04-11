using Domain.Exceptions;
using Domain.Models;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity, new()
    {
        private readonly DataContext _context;
        private readonly bool _saveChanges;
        

        public RepositoryBase(DataContext context, bool saveChanges = true)
        {
            this._context = context;
            this._saveChanges = saveChanges;
          
        }
        public virtual void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new EscamboException(e.InnerException.Message);
            }
        }

       
        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }


       public virtual T Get(params object[] id)
        {
           return _context.Set<T>().Find(id);
        }

      
        public virtual void Create(T entity, bool unSaveChanges)
        {
            if (unSaveChanges)
            {
                _context.Set<T>().Add(entity);
            }
        }

        public virtual T Create(T entity)
        {
            _context.Set<T>().Add(entity);

            if (_saveChanges)
            {
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    throw new EscamboException(e.InnerException.Message);
                }

            }
            return entity;
        }

        
        public virtual T Update(int id, T entity)
        {
            var exist = _context.Set<T>().Find(id);

            if (id != entity.Id)
            {
                throw new EscamboException("O Id do path é diferente do Id do corpo da requisição");
            }
            if (exist != null)
            {
                _context.Entry(exist).CurrentValues.SetValues(entity);
            }
            if (_saveChanges)
            {
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    throw new EscamboException(e.InnerException.Message);
                }

            }
            return entity;
        }

       




        public virtual void Delete(params object[] id)
        {
            var entity = Get(id);
            _context.Set<T>().Remove(entity);
            if (_saveChanges)
            {
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    throw new EscamboException(e.InnerException.Message);
                }
            }
        }

        



  


    }
}

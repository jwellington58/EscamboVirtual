using Domain.Exceptions;
using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Services.Impl
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : class, IEntity, new()
    {
        private readonly IRepositoryBase<T> _repository;
       
        protected ServiceBase(IRepositoryBase<T> repository)
        {
            this._repository = repository;
        }

        public virtual T Get(int id)
        {
            return _repository.Get(id);
        }
        public IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }


        public virtual T Create(T entity)
        {
            try
            {
                var result = _repository.Create(entity);
                return result;
            }
            catch (EscamboException e)
            {
                throw new EscamboException(e.Message);
            }

        }

        public virtual IQueryable<T> CreateAll(List<T> entities)
        {
            foreach (T entitiy in entities)
            {
                try
                {
                    _repository.Create(entitiy, true);
                }
                catch (EscamboException e)
                {
                    throw new EscamboException(e.Message);
                }
            }
            try
            {
                _repository.Save();
            }
            catch (EscamboException e)
            {
                throw new EscamboException(e.Message);
            }
            return entities.AsQueryable();
        }

        


        public virtual T Update(T entity, int id)
        {
            try
            {
                return _repository.Update(id, entity);
            }
            catch (EscamboException e)
            {
                throw new EscamboException(e.Message);
            }

        }
        
        public virtual void Delete(int id)
        {
            try
            {
                _repository.Delete(id);
            }
            catch (EscamboException e)
            {
                throw new EscamboException(e.Message);
            }

        }
       

    }
}

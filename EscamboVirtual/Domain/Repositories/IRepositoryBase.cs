using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRepositoryBase<T> where T : class, IEntity
    {
        void Save();
        IQueryable<T> GetAll();
        T Get(params object[] id);
       
        void Create(T entity, bool unSaveChanges);
        T Create(T etity);
       
        T Update(int id, T etity);
        
        void Delete(params object[] id);
       
        
        

        
    }

}

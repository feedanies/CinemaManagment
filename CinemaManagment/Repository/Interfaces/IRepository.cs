using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagment.Repository.Interfaces
{
    public interface IRepository<T> where T:class
    {
        T? GetByID(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

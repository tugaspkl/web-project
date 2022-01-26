using webproject.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace webproject.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T item);
        void Remove(int id);
        void Update(T item);
        T FindByID(int id);
        IEnumerable<T> FindAll();
    }
}
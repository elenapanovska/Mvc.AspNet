using System;
using System.Collections.Generic;
using System.Text;

namespace Class04.AspNet.Homework.Refactored.Data.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> Insert(T entity);
        void Update(T entity);
        int Remove(T entity);
    }
}

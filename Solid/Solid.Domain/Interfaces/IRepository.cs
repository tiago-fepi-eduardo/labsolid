using Solid.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        bool Insert(T obj);

        bool Update(T obj);

        bool Remove(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}

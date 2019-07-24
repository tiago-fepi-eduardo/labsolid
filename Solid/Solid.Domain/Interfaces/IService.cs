using FluentValidation;
using Solid.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Domain.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        bool Post<V>(T obj) where V : AbstractValidator<T>;

        bool Put<V>(T obj) where V : AbstractValidator<T>;

        bool Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}

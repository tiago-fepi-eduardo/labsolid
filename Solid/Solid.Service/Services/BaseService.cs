using FluentValidation;
using Solid.Domain.Entity;
using Solid.Domain.Interfaces;
using Solid.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public bool Post<V>(T obj) where V : AbstractValidator<T>
        {
            try
            {
                Validate(obj, Activator.CreateInstance<V>());

                _repository.Insert(obj);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Put<V>(T obj) where V : AbstractValidator<T>
        {
            try
            {
                Validate(obj, Activator.CreateInstance<V>());

                _repository.Update(obj);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IList<T> Get() => _repository.SelectAll();

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            return _repository.Select(id);
        }

        public bool Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            try
            {
                _repository.Remove(id);
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
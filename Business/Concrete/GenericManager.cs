using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using DevExpress.DataAccess.Native;
using Entities;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GenericManager<T, TValidation> : IGenericService<T> where T : class where TValidation : IValidator<T>
    {
        private readonly IGenericRepository<T> _genericRepository;
        private readonly IValidator<T> _validation;
        public GenericManager(IGenericRepository<T> genericRepository, IValidator<T> validation)
        {
            _genericRepository = genericRepository;
            _validation = validation;
        }
        public void TAdd(T entity)
        {
            ValidationResult validationResult = _validation.Validate(entity);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            _genericRepository.Add(entity);

        }

        public void TDelete(T entity)
        {
            _genericRepository.Delete(entity);
        }

        public List<T> TGetAll()
        {
            return _genericRepository.GetAll();
        }

        public T TGetById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public IQueryable<T> TGetQueryable()
        {
            return _genericRepository.GetQueryable();
        }

        public void TUpdate(T entity)
        {
            ValidationResult validationResult = _validation.Validate(entity);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            _genericRepository.Update(entity);
        }
    }
}

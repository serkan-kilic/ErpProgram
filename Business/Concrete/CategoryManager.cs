using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : GenericManager<category, CategoryValidation>,ICategoryService
    {
        public CategoryManager(ICategoryRepository categoryRepository) : base(categoryRepository,new CategoryValidation())
        {
            
        }
    }
}

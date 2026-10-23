using Entities.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation.FluentValidation
{
    public class CategoryValidation : AbstractValidator<category>
    {
        public CategoryValidation()
        {
            
        }
    }
}

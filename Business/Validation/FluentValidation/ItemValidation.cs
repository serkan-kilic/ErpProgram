using Entities.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation.FluentValidation
{
    public class ItemValidation : AbstractValidator<item>
    {
        public ItemValidation()
        {
            RuleFor(r => r.categoryid).NotEmpty().WithMessage("Ürün kategorisi boş olamaz.");
            RuleFor(r => r.itemcode).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("Ürün kodu boş olamaz.").MinimumLength(10).WithMessage("Ürün kodu 10 karakterden az olamaz");
            RuleFor(r => r.itemcode).MaximumLength(10).WithMessage("Ürün kodu 10 karakterden fazla olamaz");
            RuleFor(r => r.name).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("Ürün adı boş olamaz.").MinimumLength(3).WithMessage("Ürün adı en az 3 karakterden oluşmalı");
            RuleFor(r => r.unitprice).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("Ürün fiyatı boş olamaz.").GreaterThan(0).WithMessage("Ürün fiyatı 0'dan büyük olmalı");
        }
    }
}

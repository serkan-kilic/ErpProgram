using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation.FluentValidation
{
    public class StockValidation : AbstractValidator<stockonhand>
    {
        private readonly IStockOnHandRepository _stockOnHandRepository;
        public StockValidation(IStockOnHandRepository stockOnHandRepository)
        {
            _stockOnHandRepository = stockOnHandRepository;

            RuleFor(r => r.itemid).NotEmpty().WithMessage("Ürün adı boş olamaz.");
            RuleFor(r => r.itemcount).GreaterThan(-1).WithMessage("Ürün stoğu boş olamaz.");
            RuleFor(r => r.batchnumber).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("Parti numarası boş olamaz").Length(11).WithMessage("Parti numarası 11 haneli olamlıdır").Must((stock,batchnumber) => IsBatchNumberUnique(stock.id,batchnumber)).WithMessage("Parti numarası eşsiz olamalıdır.");
        }
        private bool IsBatchNumberUnique(int id, string batchN)
        {
            return !_stockOnHandRepository.GetAll().Any(s => s.id != id && s.batchnumber == batchN);
        }
    }
}

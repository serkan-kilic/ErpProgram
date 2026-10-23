using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;

namespace Business.Validation.FluentValidation
{
    public class OrderLineValidation : AbstractValidator<orderline>
    {
        private readonly IOrderLineRepository _orderLineRepository;
        public OrderLineValidation(IOrderLineRepository orderLineRepository)
        {
            _orderLineRepository = orderLineRepository;

            When(x => x.deleted != "d", () =>
            {
                RuleFor(x => x.orderid).NotEmpty().WithMessage("Sipariş boş bırakılamaz.");
                RuleFor(x => x.itemid).Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("Ürün boş bırakılamaz.")
                    .Must((line, itemid) => IsItemUniqueInOrder(line.id, line.orderid, itemid))
                    .WithMessage("Bu ürün siparişe zaten eklenmiş.");
                RuleFor(x => x.itemcount).GreaterThan(0).WithMessage("Ürün miktarı 0'dan büyük olmalıdır.");
                RuleFor(x => x.itemtotalprice).GreaterThan(0).WithMessage("Toplam ürün fiyatı 0'dan büyük olmalıdır.");
            });
        }
        private bool IsItemUniqueInOrder(int id, int orderid, int itemid)
        {
            return !_orderLineRepository.GetAll().Any(x => x.orderid == orderid && x.itemid == itemid && x.id != id && x.deleted != "d");
        }
    }
}
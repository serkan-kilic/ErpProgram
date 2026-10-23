using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;

namespace Business.Validation.FluentValidation
{
    public class OrderValidation : AbstractValidator<order>
    {
        private readonly IOrderRepository _orderRepository;
        public OrderValidation(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;

            RuleFor(x => x.customerid).NotEmpty().WithMessage("Müşteri boş bırakılamaz.");
            RuleFor(x => x.ordercode).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Sipariş kodu boş bırakılamaz.")
                .Must((order, ordercode) => IsOrderCodeUnique(order.id, ordercode))
                .WithMessage("Sipariş kodu eşsiz olmalıdır.");
            RuleFor(x => x.ordertypeid).NotEmpty().WithMessage("Sipariş türü boş bırakılamaz.");
            RuleFor(x => x.paymentid).NotEmpty().WithMessage("Ödeme türü boş bırakılamaz.");
            RuleFor(x => x.orderstatusid).NotEmpty().WithMessage("Sipariş durumu boş bırakılamaz.");
            RuleFor(x => x.orderdate).NotEmpty().WithMessage("Sipariş verilme tarihi boş bırakılamaz.");

            When(x => x.completeddate.HasValue, () =>
            {
                RuleFor(x => x.completeddate)
                    .Must((order, completeddate) => completeddate.Value >= order.orderdate)
                    .WithMessage("Teslim tarihi sipariş tarihinden önce olamaz.");
            });
        }
        private bool IsOrderCodeUnique(int id, string ordercode)
        {
            return !_orderRepository.GetAll().Any(x => x.ordercode == ordercode && x.id != id);
        }
    }
}
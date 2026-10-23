using DevExpress.Mvvm.Native;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation.FluentValidation
{
    public class OrderStockReservationValidation : AbstractValidator<orderstockreservation>
    {
        public OrderStockReservationValidation()
        {
            RuleFor(r => r.stockid).NotEmpty().WithMessage("Stok boş bırakılamaz");
        }
    }
}

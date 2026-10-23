using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : GenericManager<payment,PaymentValidation>,IPaymentService
    {
        public PaymentManager(IPaymentRepository paymentRepository) : base(paymentRepository,new PaymentValidation())
        {
            
        }
    }
}

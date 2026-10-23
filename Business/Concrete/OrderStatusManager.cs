using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderStatusManager : GenericManager<orderstatus, OrderStatusValidation>,IOrderStatusService
    {
        public OrderStatusManager(IOrderStatusRepository orderStatusRepository) : base(orderStatusRepository,new OrderStatusValidation())
        {
            
        }
    }
}

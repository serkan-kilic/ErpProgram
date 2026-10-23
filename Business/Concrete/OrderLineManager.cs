using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderLineManager : GenericManager<orderline,OrderLineValidation>,IOrderLineService
    {
        public OrderLineManager(IOrderLineRepository orderLineRepository):base(orderLineRepository,new OrderLineValidation(orderLineRepository))
        {

        }
    }
}

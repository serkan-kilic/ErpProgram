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
        private readonly IOrderLineRepository _orderLineRepository;
        public OrderLineManager(IOrderLineRepository orderLineRepository):base(orderLineRepository,new OrderLineValidation(orderLineRepository))
        {
            _orderLineRepository = orderLineRepository;
        }

        public void TDeleteLineWithStocks(int orderlineId)
        {
            _orderLineRepository.DeleteLineWithStocks(orderlineId);
        }
    }
}

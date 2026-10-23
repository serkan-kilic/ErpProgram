using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : GenericManager<order,OrderValidation>,IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderManager(IOrderRepository orderRepository) : base(orderRepository,new OrderValidation(orderRepository))
        {
            _orderRepository = orderRepository;
        }

        public void TDeleteOrderWithLines(int orderId)
        {
            _orderRepository.DeleteOrderWithLines(orderId);
        }
    }
}

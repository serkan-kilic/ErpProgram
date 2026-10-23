using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderStockReservationManager : GenericManager<orderstockreservation,OrderStockReservationValidation>,IOrderStockReservationService
    {
        public OrderStockReservationManager(IOrderStockReservationRepository orderStockReservationRepository) : base(orderStockReservationRepository, new OrderStockReservationValidation())
        {
            
        }
    }
}

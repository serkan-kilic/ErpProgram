using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderTypeManager : GenericManager<ordertype,OrderTypeValidation>,IOrderTypeService
    {
        public OrderTypeManager(IOrderTypeRepository orderTypeRepository) : base(orderTypeRepository, new OrderTypeValidation())
        {
            
        }
    }
}

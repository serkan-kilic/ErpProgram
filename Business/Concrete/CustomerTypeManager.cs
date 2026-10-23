using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerTypeManager : GenericManager<customertype,CustomerTypeValidation>,ICustomerTypeService
    {
        public CustomerTypeManager(ICustomerTypeRepository customerTypeRepository) : base(customerTypeRepository,new CustomerTypeValidation())
        {
            
        }
    }
}

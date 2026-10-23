using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : GenericManager<customer,CustomerValidation>,ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository customerRepository) : base(customerRepository,new CustomerValidation(customerRepository))
        {
            _customerRepository = customerRepository;
        }

        public void TDeleteCustomerWithOrderAndLines(int customerId)
        {
            _customerRepository.DeleteCustomerWithOrderAndLines(customerId);
        }

        public List<customer> TGetCustomerWithDistrict()
        {
            return _customerRepository.GetCustomersWithDistrict();
        }
    }
}

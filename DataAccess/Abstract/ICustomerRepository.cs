using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerRepository : IGenericRepository<customer>
    {
        List<customer> GetCustomersWithDistrict();
        void DeleteCustomerWithOrderAndLines(int customerId);
    }
}

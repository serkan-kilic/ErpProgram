using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService : IGenericService<customer>
    {
        List<customer> TGetCustomerWithDistrict();
        void TDeleteCustomerWithOrderAndLines(int customerId);
    }
}

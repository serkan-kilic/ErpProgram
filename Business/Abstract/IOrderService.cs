using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService : IGenericService<order>
    {
        void TDeleteOrderWithLines(int orderId);
    }
}

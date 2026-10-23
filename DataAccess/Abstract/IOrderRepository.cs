using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IOrderRepository : IGenericRepository<order>
    {
        void DeleteOrderWithLines(int orderId);
    }
}

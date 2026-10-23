using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IStockOnHandRepository : IGenericRepository<stockonhand>
    {
        void DeleteStockWithOrderStockReservation(int stockId);
    }
}

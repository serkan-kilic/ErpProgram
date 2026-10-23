using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStockOnHandService : IGenericService<stockonhand>
    {
        void TDeleteStockWithOrderStockReservation(int stockId);
    }
}

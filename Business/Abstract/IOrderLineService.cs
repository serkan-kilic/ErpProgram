using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderLineService : IGenericService<orderline>
    {
        void TDeleteLineWithStocks(int orderlineId);
    }
}

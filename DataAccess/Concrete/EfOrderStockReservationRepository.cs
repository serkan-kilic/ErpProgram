using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfOrderStockReservationRepository : EfGenericRepository<orderstockreservation>,IOrderStockReservationRepository
    {
        public EfOrderStockReservationRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}

using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfStockOnHandRepository : EfGenericRepository<stockonhand>,IStockOnHandRepository
    {
        public EfStockOnHandRepository(AppDbContext context) : base(context)
        {
            
        }

        public void DeleteStockWithOrderStockReservation(int stockId)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var orderstockreservations = _context.Set<orderstockreservation>().Where(os => os.stockid == stockId && os.deleted != "d");
                var stock = _context.Set<stockonhand>().Find(stockId);

                foreach (var osr in orderstockreservations)
                {
                    osr.deleted = "d";
                }
                if (stock != null)
                {
                    stock.deleted = "d";
                }
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}

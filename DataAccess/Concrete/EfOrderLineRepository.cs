using DataAccess.Abstract;
using DataAccess.Context;
using DevExpress.PivotGrid.OLAP;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static DevExpress.Utils.Zip.Internal.SecureZipTrace;

namespace DataAccess.Concrete
{
    public class EfOrderLineRepository : EfGenericRepository<orderline>,IOrderLineRepository
    {
        public EfOrderLineRepository(AppDbContext context) : base(context)
        {
            
        }

        public void DeleteLineWithStocks(int orderlineId)
        {
            using var transection = _context.Database.BeginTransaction();
            try
            {
                var linestock = _context.Set<orderstockreservation>().Where(o => o.orderlineid == orderlineId && o.deleted != "d").ToList();
                foreach (var ls in linestock)
                {
                    var stock = _context.Set<stockonhand>().FirstOrDefault(s => s.id == ls.stockid);
                    if (stock != null)
                    {
                        stock.itemcount += ls.selectedcount;
                    }

                    ls.deleted = "d";
                }

                var line = _context.Set<orderline>().FirstOrDefault(o => o.id == orderlineId);
                if (line != null)
                {
                    line.deleted = "d";
                }

                _context.SaveChanges();
                transection.Commit();
            }
            catch (Exception)
            {
                transection.Rollback();
                throw;
            }
        }
    }
}

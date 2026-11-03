using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfOrderRepository : EfGenericRepository<order>, IOrderRepository
    {
        public EfOrderRepository(AppDbContext context) : base(context)
        {
            
        }

        public void DeleteOrderWithLines(int orderId)
        {
            using var transection = _context.Database.BeginTransaction();
            try
            {
                var lines = _context.Set<orderline>().Where(l => l.orderid == orderId && l.deleted != "d").ToList();
                foreach (var line in lines)
                {
                    var linestock = _context.Set<orderstockreservation>().Where(o => o.orderlineid == line.id && o.deleted != "d").ToList();
                    foreach (var ls in linestock)
                    {
                        var stock = _context.Set<stockonhand>().FirstOrDefault(s => s.id == ls.stockid);
                        if (stock != null)
                        {
                            stock.itemcount += ls.selectedcount;
                        }
                        ls.deleted = "d";
                    }
                    line.deleted = "d";
                }

                var order = _context.Set<order>().FirstOrDefault(o=> o.id == orderId);
                if(order != null)
                {
                    order.deleted = "d";
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

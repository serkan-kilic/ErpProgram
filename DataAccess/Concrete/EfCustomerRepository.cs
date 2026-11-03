using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCustomerRepository : EfGenericRepository<customer>, ICustomerRepository
    {
        public EfCustomerRepository(AppDbContext context) : base(context)
        {

        }

        public List<customer> GetCustomersWithDistrict()
        {
            return _context.customer.Include(x => x.District).ToList();
        }

        public void DeleteCustomerWithOrderAndLines(int customerId)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var orders = _context.Set<order>().Where(o => o.customerid == customerId && o.deleted != "d").ToList();

                var orderIds = orders.Select(o => o.id).ToList();

                var lines = _context.Set<orderline>().Where(l => orderIds.Contains(l.orderid) && l.deleted != "d").ToList();

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
                foreach (var order in orders)
                {
                    order.deleted = "d";
                }

                var customer = _context.Set<customer>().FirstOrDefault(c=> c.id == customerId);
                if (customer != null)
                {
                    customer.deleted = "d";
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

using DataAccess.Abstract;
using DataAccess.Context;
using DevExpress.Data.ODataLinq.Helpers;
using Entities.concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfItemRepository : EfGenericRepository<item>, IItemRepository
    {

        public EfItemRepository(AppDbContext context) : base(context)
        {
        }

        public void DeleteItemWithLineAndStock(int ItemId)
        {
            using var transection = _context.Database.BeginTransaction();
            try
            {
                var Item = _context.Set<item>().FirstOrDefault(i => i.id == ItemId);
                if (Item != null)
                {
                    var lines = _context.Set<orderline>().Where(l => l.itemid == ItemId && l.deleted != "d").ToList();
                    var stocks = _context.Set<stockonhand>().Where(s => s.itemid == ItemId && s.deleted != "d").ToList();

                    foreach (var line in lines)
                    {
                        var orderstock = _context.Set<orderstockreservation>().Where(o => o.orderlineid == line.id).ToList();
                        var order = _context.Set<order>().FirstOrDefault(o => o.id == line.orderid);
                        if (order != null)
                        {
                            order.ordertotalprice -= line.itemtotalprice;
                        }
                        foreach (var os in orderstock)
                        {
                            //var stock = _context.Set<stockonhand>().FirstOrDefault(s => s.id == os.stockid); //silinen stoğa veri eklemeye gerek yok
                            //if (stock != null)
                            //{
                            //    stock.itemcount += os.selectedcount;
                            //}
                            os.deleted = "d";
                        }
                        line.deleted = "d";
                    }
                    foreach (var stock in stocks)
                    {
                        stock.deleted = "d";
                    }


                    Item.deleted = "d";
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

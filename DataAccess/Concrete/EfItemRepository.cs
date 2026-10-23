using DataAccess.Abstract;
using DataAccess.Context;
using Entities.concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfItemRepository : EfGenericRepository<item>,IItemRepository
    {

        public EfItemRepository(AppDbContext context) : base(context)
        {
        }

        public void DeleteItemWithLineAndStock(int ItemId)
        {
            using var transection = _context.Database.BeginTransaction();
            try
            {
                var lines = _context.Set<orderline>().Where(l => l.itemid == ItemId && l.deleted != "d").ToList();
                var stock = _context.Set<stockonhand>().FirstOrDefault(s => s.itemid == ItemId && s.deleted != "d");

                foreach (var line in lines)
                {
                    line.deleted = "d";
                }
                if (stock != null)
                {
                    stock.deleted = "d";
                }

                var Item = _context.Set<item>().Find(ItemId);
                if (Item != null)
                {
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

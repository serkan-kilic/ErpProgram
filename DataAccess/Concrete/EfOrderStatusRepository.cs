using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfOrderStatusRepository : EfGenericRepository<orderstatus>,IOrderStatusRepository
    {
        public EfOrderStatusRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}

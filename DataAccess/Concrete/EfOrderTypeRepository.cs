using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfOrderTypeRepository : EfGenericRepository<ordertype>,IOrderTypeRepository
    {
        public EfOrderTypeRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}

using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCustomerTypeRepository : EfGenericRepository<customertype>,ICustomerTypeRepository
    {
        public EfCustomerTypeRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}

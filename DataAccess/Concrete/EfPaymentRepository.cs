using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfPaymentRepository : EfGenericRepository<payment>, IPaymentRepository
    {
        public EfPaymentRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}

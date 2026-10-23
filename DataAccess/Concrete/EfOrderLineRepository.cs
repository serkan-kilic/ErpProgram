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
    }
}

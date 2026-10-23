using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfProvinceRepository : EfGenericRepository<province>,IProvinceRepository
    {
        public EfProvinceRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}

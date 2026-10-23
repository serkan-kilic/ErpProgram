using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfDistrictRepository : EfGenericRepository<district>,IDistrictRepository
    {
        public EfDistrictRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}

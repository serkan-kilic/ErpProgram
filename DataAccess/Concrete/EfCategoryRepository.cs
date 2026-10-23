using DataAccess.Abstract;
using DataAccess.Context;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCategoryRepository : EfGenericRepository<category>,ICategoryRepository
    {
        public EfCategoryRepository(AppDbContext context) : base(context)
        {

        }
    }
}

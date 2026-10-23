using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IItemRepository : IGenericRepository<item>
    {
        void DeleteItemWithLineAndStock(int ItemId);
    }
}

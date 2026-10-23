using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class order : ISoftDeletable
    {
        public int id { get; set; }
        public int customerid { get; set; }
        public int ordertypeid { get; set; }
        public int paymentid { get; set; }
        public int orderstatusid { get; set; }
        public string ordercode { get; set; }
        public DateOnly orderdate { get; set; }
        public DateOnly? completeddate { get; set; }
        public decimal ordertotalprice { get; set; }
        public string? deleted { get; set; }
    }
}

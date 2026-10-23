using Entities.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class orderline : ISoftDeletable
    {
        public int id { get; set; }
        public int itemid { get; set; }
        public int orderid { get; set; }
        public decimal itemtotalprice { get; set; }
        public int itemcount { get; set; }
        public string? deleted { get; set; }
    }
}

using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.concrete
{
    public class item : ISoftDeletable
    {
        public int id {  get; set; }
        public int categoryid { get; set; }
        public string itemcode { get; set; }
        public string name { get; set; }
        public decimal unitprice { get; set; }
        public string? deleted { get; set; }
    }
}

using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class orderstockreservation : ISoftDeletable
    {
        public int id { get; set; }
        public int stockid { get; set; }
        public int orderlineid { get; set; }
        public int selectedcount { get; set; }
        public string? deleted { get; set; }
    }
}

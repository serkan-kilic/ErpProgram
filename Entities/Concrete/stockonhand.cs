using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class stockonhand : ISoftDeletable
    {
        public int id { get; set; }
        public int itemid { get; set; }
        public int itemcount { get; set; }
        public string batchnumber { get; set; }
        public string? deleted { get; set; }
    }
}

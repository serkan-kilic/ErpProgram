using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace Entities.Concrete
{
    public class district
    {
        public int id {  get; set; }
        public int provinceid {  get; set; }
        public string name { get; set; }
    }
}

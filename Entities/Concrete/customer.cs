using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class customer : ISoftDeletable
    {
        public int id {  get; set; }
        public int districtid { get; set; }
        public int customertypeid { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string phonenumber { get; set; }
        public string email { get; set; }
        public string? address { get; set; }
        public string? tckn { get; set; }
        public string? vkn { get; set; }
        public string? title { get; set; }
        public string? taxoffice { get; set; }
        public string currency { get; set; }

        public virtual district District { get; set; }
        public string? deleted { get; set; }
    }
}

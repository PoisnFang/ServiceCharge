using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceCharge.Web.Data
{
    public class MenuItem
    {
        public string Name { get; set; }
        public ItemTemp ItemTemp { get; set; }
        public decimal Price { get; set; }
        public ItemType ItemType { get; set; }
    }
}
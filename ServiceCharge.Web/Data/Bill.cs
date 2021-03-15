using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceCharge.Web.Data
{
    public class Bill
    {
        // Amount of tax to add 1 + taxt percent
        private decimal _serviceCharge = 1.1m;

        // The items the the user is ordering
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        // Total price of all items in MenuItems
        public decimal Total
        {
            get
            {
                var total = 0m;
                if (MenuItems != null)
                {
                    total = MenuItems.Select(i => i.Price).ToList().Sum();
                    if (MenuItems.Any(i => i.ItemType == ItemType.Food))
                    {
                        total *= _serviceCharge;
                    }
                }
                return decimal.Round(total, 2);
            }
        }
    }
}
using System.Collections.Generic;

namespace ServiceCharge.Web.Data
{
    public static class Menu
    {
        public static List<MenuItem> MenuItems { get; set; } = new List<MenuItem> {
            new MenuItem { Name = "Cola", ItemTemp = ItemTemp.Cold, Price = 0.5m, ItemType = ItemType.Drink },
            new MenuItem { Name = "Coffee", ItemTemp = ItemTemp.Hot, Price = 1m, ItemType = ItemType.Drink },
            new MenuItem { Name = "Cheese Sandwich", ItemTemp = ItemTemp.Cold, Price = 2m, ItemType = ItemType.Food },
            new MenuItem { Name = "Steak Sandwich", ItemTemp = ItemTemp.Hot, Price = 4.5m, ItemType = ItemType.Food },
        };
    }
}
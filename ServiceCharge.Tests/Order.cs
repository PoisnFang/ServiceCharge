using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceCharge.Web.Data;
using System.Linq;

namespace ServiceCharge.Tests
{
    [TestClass]
    public class Order
    {
        [TestMethod]
        public void AllItems()
        {
            var bill = new Bill();

            foreach (var item in Menu.MenuItems)
            {
                bill.MenuItems.Add(item);
            }
            Assert.AreEqual(8.8m, bill.Total);
        }

        [TestMethod]
        public void OnlyFoodItems()
        {
            var bill = new Bill();

            foreach (var item in Menu.MenuItems.Where(i => i.ItemType == ItemType.Food))
            {
                bill.MenuItems.Add(item);
            }
            Assert.AreEqual(7.15m, bill.Total);
        }

        [TestMethod]
        public void OnlyDrinkItems()
        {
            var bill = new Bill();

            foreach (var item in Menu.MenuItems.Where(i => i.ItemType == ItemType.Drink))
            {
                bill.MenuItems.Add(item);
            }
            Assert.AreEqual(1.5m, bill.Total);
        }
    }
}
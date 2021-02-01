using CoffeeShopOrder.Core.Enum;
using CoffeeShopOrder.Core.Interface;
using System.Collections.Generic;

namespace CoffeeShopOrder.Core.Model
{
    public class Beverage : IBeverage
    {
        public BeverageType BeverageName { get; set; }
        public int BeverageQuantity { get; set; }
        public decimal BeveragePrice { get; set; }
        public List<Addition> Additions { get; set; }

        public Beverage(BeverageType beverageName, int beverageQuantity, decimal beveragePrice)
        {
            BeverageName = beverageName;
            BeverageQuantity = beverageQuantity;
            BeveragePrice = beveragePrice;
        }

        public Beverage()
        {
            Additions = new List<Addition>();
        }
    }
}

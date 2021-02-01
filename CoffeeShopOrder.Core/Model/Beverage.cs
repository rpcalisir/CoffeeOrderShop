using CoffeeShopOrder.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Core.Model
{
    public class Beverage : IBeverage
    {
        public string BeverageName { get; set; }
        public int BeverageQuantity { get; set; }
        public decimal BeveragePrice { get; set; }
        public List<Addition> Additions { get; set; }

        public Beverage(string beverageName, int beverageQuantity, decimal beveragePrice)
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

using CoffeeShopOrder.Core.Interface;
using CoffeeShopOrder.Core.Model;
using CoffeeShopOrder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Business
{
    public class Order : IOrder
    {
        //public List<Beverage> Availables { get; set; } = new List<Beverage>();
        public List<Beverage> Orders { get; set; } = new List<Beverage>();

        public decimal GetTotalPrice()
        {
            decimal totalBeveragePrice = Orders.Sum(p => (p.BeveragePrice * p.BeverageQuantity));
            var additionPrices = Orders.SelectMany(a => a.Additions)
                                               .GroupBy(i => i.AdditionName)
                                               .Select(grp => new
                                               {
                                                   Prc = grp.Key,
                                                   Sum = grp.Sum(t => t.AdditionPrice * t.AdditionQuantity)
                                               });
            decimal totalAdditionPrice = additionPrices.Sum(t => t.Sum);
            return totalAdditionPrice + totalBeveragePrice;
        }

    }
}

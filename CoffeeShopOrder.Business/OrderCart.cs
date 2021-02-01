using CoffeeShopOrder.Core.Interface;
using CoffeeShopOrder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Business
{
    public class OrderCart
    {
        public List<Beverage> Availables { get; set; } = new List<Beverage>();

        public List<Beverage> Items { get; set; } = new List<Beverage>();

        public decimal GetTotalPrice()
        {
            decimal totalBeveragePrice = Items.Sum(p => (p.BeveragePrice * p.BeverageQuantity));
            var additionPrices = Items.SelectMany(a => a.Additions)
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

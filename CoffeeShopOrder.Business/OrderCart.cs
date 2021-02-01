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
            int totalBeveragePrice = Items.Sum(p => p.BeveragePrice * p.BeverageQuantity);
        }

    }
}

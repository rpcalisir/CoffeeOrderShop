using CoffeeShopOrder.Core.Model;
using System.Collections.Generic;

namespace CoffeeShopOrder.Interface
{
    public interface IOrder
    {
        List<Beverage> Orders { get; set; }

        decimal GetTotalPrice();
    }
}
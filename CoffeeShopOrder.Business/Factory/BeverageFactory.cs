using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Business.Factory
{
    public class BeverageFactory : IBeverageFactory
    {
        public BeverageType GetBeverageType(string beverageType)
        {
            switch (beverageType.ToLower())
            {
                case "black coffee":
                    return BeverageType.blackCoffee;
                case "latte":
                    return BeverageType.latte;
                case "mocha":
                    return BeverageType.mocha;
                case "tea":
                    return BeverageType.tea;
                default:
                    return BeverageType.none;
            }
        }
    }
}

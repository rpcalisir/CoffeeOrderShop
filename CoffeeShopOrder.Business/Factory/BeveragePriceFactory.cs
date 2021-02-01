using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Business.Factory
{
    public class BeveragePriceFactory : IBeveragePriceFactory
    {
        public decimal GetBeveragePrice(BeverageType beverageType)
        {
            switch (beverageType)
            {
                case BeverageType.blackCoffee:
                    return 5M;
                case BeverageType.latte:
                    return 7M;
                case BeverageType.mocha:
                    return 9M;
                case BeverageType.tea:
                    return 2M;
                default:
                    return 0;
            }
        }
    }
}

using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.Core.Enum;

namespace CoffeeShopOrder.Business.Factory
{
    public class BeverageFactory : IBeverageFactory
    {
        public BeverageType GetBeverageType(string beverageType)
        {
            switch (beverageType.ToLower())
            {
                case "1":
                    return BeverageType.blackCoffee;
                case "2":
                    return BeverageType.latte;
                case "3":
                    return BeverageType.mocha;
                case "4":
                    return BeverageType.tea;
                default:
                    return BeverageType.none;
            }
        }
    }
}

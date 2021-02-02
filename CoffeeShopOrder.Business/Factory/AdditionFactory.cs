using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeShopOrder.Business.Factory
{
    public class AdditionFactory : IAdditionFactory
    {
        public AdditionType GetBeverageType(string additionType)
        {
            switch (additionType.ToLower())
            {
                case "1":
                    return AdditionType.milk;
                case "2":
                    return AdditionType.chocolateSauce;
                case "3":
                    return AdditionType.hazelnutSyrup;
                default:
                    return AdditionType.none;
            }
        }
    }
}

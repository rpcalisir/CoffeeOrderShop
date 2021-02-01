using CoffeeShopOrder.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Business.Factory
{
    public class AdditionFactory
    {
        public AdditionType GetBeverageType(string additionType)
        {
            switch (additionType.ToLower())
            {
                //case "milk":
                //    return AdditionType.milk;
                //case "chocolate sauce":
                //    return AdditionType.chocolateSauce;
                //case "hazelnut syrup":
                //    return AdditionType.hazelnutSyrup;
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

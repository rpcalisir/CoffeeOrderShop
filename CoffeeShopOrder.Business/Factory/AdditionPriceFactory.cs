using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Business.Factory
{
    public class AdditionPriceFactory : IAdditionPriceFactory
    {
        public decimal GetAdditionPrice(AdditionType additionType)
        {
            switch (additionType)
            {
                case AdditionType.milk:
                    return 2M;
                case AdditionType.chocolateSauce:
                    return 4M;
                case AdditionType.hazelnutSyrup:
                    return 6M;
                default:
                    return 0;
            }
        }
    }
}

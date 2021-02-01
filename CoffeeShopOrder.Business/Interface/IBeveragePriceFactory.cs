using CoffeeShopOrder.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Business.Interface
{
    public interface IBeveragePriceFactory
    {
        decimal GetBeveragePrice(BeverageType beverageType);
    }
}

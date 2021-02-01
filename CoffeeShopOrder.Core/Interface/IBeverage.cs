using CoffeeShopOrder.Core.Enum;
using CoffeeShopOrder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Core.Interface
{
    public interface IBeverage
    {
        BeverageType BeverageName { get; set; }
        int BeverageQuantity { get; set; }
        decimal BeveragePrice { get; set; }
        List<Addition> Additions { get; set; }
    }
}

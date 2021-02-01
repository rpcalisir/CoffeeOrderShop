using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CoffeeShopOrder.Core.Enum
{
    public enum BeverageType
    {
        none,
        [Description("Black Coffee")]
        blackCoffee,
        [Description("Latte")]
        latte,
        [Description("Mocha")]
        mocha,
        [Description("Tea")]
        tea
    }
}

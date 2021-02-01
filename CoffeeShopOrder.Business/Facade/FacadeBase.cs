using CoffeeShopOrder.Business.Factory;
using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Business.Facade
{
    public abstract class FacadeBase
    {
        protected static readonly IBeveragePriceFactory _beveragePriceFactory = new BeveragePriceFactory();
        protected static readonly IAdditionPriceFactory _additionPriceFactory = new AdditionPriceFactory();
        protected static readonly IOrder _order = new Order();
    }
}

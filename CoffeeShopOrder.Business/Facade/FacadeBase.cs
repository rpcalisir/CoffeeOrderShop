using CoffeeShopOrder.Business.Factory;
using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.Interface;

namespace CoffeeShopOrder.Business.Facade
{
    public abstract class FacadeBase
    {
        protected static readonly IBeveragePriceFactory _beveragePriceFactory = new BeveragePriceFactory();
        protected static readonly IAdditionPriceFactory _additionPriceFactory = new AdditionPriceFactory();
        //Instantiate list from here to add onto total price in a sequence of orders
        //protected static readonly IOrder _order = new Order();
    }
}

using CoffeeShopOrder.Core.Enum;
using CoffeeShopOrder.Core.Model;
using CoffeeShopOrder.Interface;
using System.Collections.Generic;

namespace CoffeeShopOrder.Business.Facade
{
    public class OrderManagement : FacadeBase
    {
        public IOrder PlaceOrder(BeverageType beverageType, int beverageQuantity, AdditionType additionType = AdditionType.none, int additionQuantity = 0)
        {
            _order.Orders.Add(new Beverage
            {
                BeverageName = beverageType,
                BeverageQuantity = beverageQuantity,
                BeveragePrice = _beveragePriceFactory.GetBeveragePrice(beverageType),
                Additions = new List<Addition>
                {
                   new Addition{ AdditionName = additionType, AdditionPrice = _additionPriceFactory.GetAdditionPrice(additionType), AdditionQuantity = additionQuantity }
                }
            });
            return _order;

            //PlaceOrder(cart);
        }
        //public decimal GetTotalPrice()
        //{
        //    decimal totalBeveragePrice = Items.Sum(p => (p.BeveragePrice * p.BeverageQuantity));
        //    var additionPrices = Items.SelectMany(a => a.Additions)
        //                                       .GroupBy(i => i.AdditionName)
        //                                       .Select(grp => new
        //                                       {
        //                                           Prc = grp.Key,
        //                                           Sum = grp.Sum(t => t.AdditionPrice * t.AdditionQuantity)
        //                                       });
        //    decimal totalAdditionPrice = additionPrices.Sum(t => t.Sum);
        //    return totalAdditionPrice + totalBeveragePrice;
        //}

        //private static void PlaceOrder(OrderCart cart)
        //{
        //    cart.Items.Add(new Beverage
        //    {
        //        BeverageName = BeverageType.latte,
        //        BeverageQuantity = 1,
        //        BeveragePrice = 9M,
        //        Additions = new List<Addition>
        //        {
        //           new Addition{ AdditionName = "Milk", AdditionPrice = 2M, AdditionQuantity = 1 },
        //           new Addition{ AdditionName = "Hazelnut Syrup", AdditionPrice = 2, AdditionQuantity = 1 }
        //        }
        //    });
        //}
    }
}

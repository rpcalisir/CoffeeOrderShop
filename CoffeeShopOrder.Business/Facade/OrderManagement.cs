﻿using CoffeeShopOrder.Core.Enum;
using CoffeeShopOrder.Core.Model;
using CoffeeShopOrder.Interface;
using System.Collections.Generic;

namespace CoffeeShopOrder.Business.Facade
{
    public class OrderManagement : FacadeBase
    {
        //Instantiate the Order object here for seperate calculation of total price
        protected IOrder _order;
        public OrderManagement()
        {
            _order = new Order();
        }
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
        }
    }
}

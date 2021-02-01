using CoffeeShopOrder.Business.Factory;
using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.Core.Enum;
using CoffeeShopOrder.Core.Model;
using System.Collections.Generic;

namespace CoffeeShopOrder.Business
{
    public class PopulateCart
    {
        private readonly IBeveragePriceFactory _beveragePriceFactory;

        public PopulateCart()
        {
            _beveragePriceFactory = new BeveragePriceFactory();
        }
        public static void GetAvailableDrinks(OrderCart cart)
        {

            cart.Availables.Add(new Beverage { BeverageName = BeverageType.blackCoffee});
            cart.Availables.Add(new Beverage { BeverageName = BeverageType.latte});
            cart.Availables.Add(new Beverage { BeverageName = BeverageType.mocha});
            cart.Availables.Add(new Beverage { BeverageName = BeverageType.tea});
        }

        public void PopulateCartWithSampleData(OrderCart cart)
        {
            //cart.Items.Add(new Beverage
            //{
            //    BeverageName = BeverageType.blackCoffee,
            //    BeverageQuantity = 1,
            //    BeveragePrice = _beveragePriceFactory.GetBeveragePrice(BeverageType.blackCoffee),
            //    Additions = new List<Addition>
            //    {
            //       new Addition{ AdditionName = "Milk", AdditionPrice = 2M, AdditionQuantity = 1 }
            //    }
            //});

            //cart.Items.Add(new Beverage("Black Coffee", 1, 5M).Additions.Add(new Addition
            //{
            //    AdditionName = "Garlic",
            //    AdditionPrice = 0.1,
            //    AdditionQuantity = 1
            //}); 

            //cart.Items.Add(new Beverage
            //{
            //    BeverageName = BeverageType.mocha,
            //    BeverageQuantity = 1,
            //    BeveragePrice = 7M,
            //    Additions = new List<Addition>
            //    {
            //       new Addition{ AdditionName = "Milk", AdditionPrice = 2M, AdditionQuantity = 2 }
            //    }
            //});
            //PlaceOrder(cart);
        }

        private static void PlaceOrder(OrderCart cart)
        {
            //cart.Items.Add(new Beverage
            //{
            //    BeverageName = BeverageType.latte,
            //    BeverageQuantity = 1,
            //    BeveragePrice = 9M,
            //    Additions = new List<Addition>
            //    {
            //       new Addition{ AdditionName = "Milk", AdditionPrice = 2M, AdditionQuantity = 1 },
            //       new Addition{ AdditionName = "Hazelnut Syrup", AdditionPrice = 2, AdditionQuantity = 1 }
            //    }
            //});
        }
    }
}

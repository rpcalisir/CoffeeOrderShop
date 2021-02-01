using CoffeeShopOrder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Business
{
    public class PopulateCart
    {
        public static void GetAvailableDrinks(OrderCart cart)
        {

            cart.Availables.Add(new Beverage { BeverageName = "Black Coffee"});
            cart.Availables.Add(new Beverage { BeverageName = "Latte"});
            cart.Availables.Add(new Beverage { BeverageName = "Mocha"});
            cart.Availables.Add(new Beverage { BeverageName = "Tea"});
        }

        public static void PopulateCartWithSampleData(OrderCart cart)
        {
            cart.Items.Add(new Beverage
            {
                BeverageName = "Black Coffee",
                BeverageQuantity = 1,
                BeveragePrice = 5M,
                Additions = new List<Addition>
                {
                   new Addition{ AdditionName = "Milk", AdditionPrice = 2M, AdditionQuantity = 1 }
                }
            });


            //cart.Items.Add(new Beverage("Black Coffee", 1, 5M).Additions.Add(new Addition
            //{
            //    AdditionName = "Garlic",
            //    AdditionPrice = 0.1,
            //    AdditionQuantity = 1
            //}); 

            cart.Items.Add(new Beverage
            {
                BeverageName = "Mocha",
                BeverageQuantity = 1,
                BeveragePrice = 7M,
                Additions = new List<Addition>
                {
                   new Addition{ AdditionName = "Milk", AdditionPrice = 2M, AdditionQuantity = 2 }
                }
            });

            cart.Items.Add(new Beverage
            {
                BeverageName = "Latte",
                BeverageQuantity = 1,
                BeveragePrice = 9M,
                Additions = new List<Addition>
                {
                   new Addition{ AdditionName = "Milk", AdditionPrice = 2M, AdditionQuantity = 1 },
                   new Addition{ AdditionName = "Hazelnut Syrup", AdditionPrice = 2, AdditionQuantity = 1 }
                }
            });
        }
    }
}

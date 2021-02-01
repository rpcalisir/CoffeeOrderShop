using CoffeeShopOrder.Business;
using CoffeeShopOrder.Business.Facade;
using CoffeeShopOrder.Business.Factory;
using CoffeeShopOrder.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.ConsoleUI
{
    class Program
    {
        //static readonly OrderCart cart = new OrderCart();
        static readonly OrderCart available = new OrderCart();

        //static readonly PopulateCart populate = new PopulateCart();



        static readonly OrderManagement orderManagement = new OrderManagement();

        static readonly BeverageFactory beverageFactory = new BeverageFactory();
        static readonly AdditionFactory additionFactory = new AdditionFactory();

        static void Main(string[] args)
        {
            //Displays all available beverages
            PopulateCart.GetAvailableDrinks(available);
            Console.WriteLine("Available Bavareges:");

            foreach (var item in available.Availables)
            {
                Console.WriteLine("Beverage: " + item.BeverageName);
            }

            Console.WriteLine();


            Console.WriteLine("What's your choice of beverage?");
            string beverageType = Console.ReadLine();
            while (string.IsNullOrEmpty(beverageType) && beverageFactory.GetBeverageType(beverageType)==BeverageType.none)
            {
                Console.WriteLine("Beverage type is empty or invalid! Please check and enter again.");
                beverageType = Console.ReadLine();
            } 

            Console.WriteLine("How many of beverages would you like?");
            int beverageQuantity;
            string beverageQuantityStr = Console.ReadLine();
            while (!int.TryParse(beverageQuantityStr, out beverageQuantity))
            {
                Console.WriteLine("Quantity is invalid! Please check and enter again.");
                beverageQuantityStr = Console.ReadLine();
            }

            Console.WriteLine("What's your choice of addition?");
            Console.WriteLine("Enter -1 in case no addition is desired.");
            string additionType = Console.ReadLine();
            while (string.IsNullOrEmpty(additionType) && additionFactory.GetBeverageType(additionType) == AdditionType.none && additionType!="-1")
            {
                Console.WriteLine("Addition type is empty or invalid! Please check and enter again.");
                additionType = Console.ReadLine();
            }


            int additionQuantity = 0;
            if (additionType!="-1")
            {
                Console.WriteLine("How many of additions would you like?");
                string additionQuantityStr = Console.ReadLine();
                while (!int.TryParse(additionQuantityStr, out additionQuantity))
                {
                    Console.WriteLine("Quantity is invalid! Please check and enter again.");
                    additionQuantityStr = Console.ReadLine();
                }
            }

            var cart = orderManagement.PlaceOrder(beverageFactory.GetBeverageType(beverageType), beverageQuantity, additionFactory.GetBeverageType(additionType), additionQuantity);







            //Mocking a sample order from the user
            //populate.PopulateCartWithSampleData(cart);

            ////Displays mocked order
            //Console.WriteLine("Ordered beverages:");
            //foreach (var item in cart.Items) 
            //{
            //    Console.WriteLine("Beverage:");
            //    Console.WriteLine("Beverage Name: " + item.BeverageName);
            //    Console.WriteLine("Beverage Quantity: " + item.BeverageQuantity);
            //    Console.WriteLine("Beverage Price: " + item.BeveragePrice);
            //    Console.WriteLine("Additions:");
            //    foreach (var addition in item.Additions)
            //    {
            //        Console.WriteLine("Addition Name: " + addition.AdditionName);
            //        Console.WriteLine("Addition Price: " + addition.AdditionPrice);
            //        Console.WriteLine("Addition Quantity: " + addition.AdditionQuantity);
            //    }
            //    Console.WriteLine();
            //}

            //Displays current total for the placed order
            Console.WriteLine("Total cost: " + cart.GetTotalPrice());

            Console.ReadLine();
        }
    }
}

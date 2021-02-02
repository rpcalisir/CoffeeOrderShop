using CoffeeShopOrder.Business;
using CoffeeShopOrder.Business.Facade;
using CoffeeShopOrder.Business.Factory;
using CoffeeShopOrder.Business.Helper;
using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.Core.Enum;
using CoffeeShopOrder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeShopOrder.ConsoleUI
{
    class Program
    {
        static readonly OrderManagement orderManagement = new OrderManagement();
        static readonly IBeverageFactory beverageFactory = new BeverageFactory();
        static readonly IAdditionFactory additionFactory = new AdditionFactory();

        static void Main(string[] args)
        {
            //Displays all available beverages
            Console.WriteLine("{0,-20}\n", "Available Bavareges:");
            //foreach (var beverageName in GetBeverages.GetAllBeverages())
            DisplayBeverages();

            Console.WriteLine();

            //Display all available additions
            Console.WriteLine("{0,-20}\n", "Available Additions:");
            DisplayAdditions();

            Console.WriteLine("What's your choice of beverage?");
            string beverageType = GetBeverageType();

            Console.WriteLine("How many of beverages would you like?");
            int beverageQuantity = GetBeverageQuantity();

            Console.WriteLine("What's your choice of addition?");
            Console.WriteLine("Enter -1 in case no addition is desired.");
            string additionType = GetAdditionType();

            int additionQuantity = 0;
            if (additionType != "-1")
            {
                Console.WriteLine("How many of additions would you like?");
                additionQuantity = GetAdditionQuantity();
            }

            var cart = orderManagement.PlaceOrder(beverageFactory.GetBeverageType(beverageType), beverageQuantity, additionFactory.GetBeverageType(additionType), additionQuantity);

            ////Displays mocked order
            Console.WriteLine("Ordered Beverages:");
            DisplayMockedOrder(cart);

            //Displays current total for the placed order
            Console.WriteLine("Total amount: " + cart.GetTotalPrice());

            Console.ReadLine();
        }

        private static void DisplayMockedOrder(IOrder cart)
        {
            foreach (var order in cart.Orders)
            {
                Console.WriteLine("Beverage:");
                Console.WriteLine("Beverage Name: " + order.BeverageName);
                Console.WriteLine("Beverage Quantity: " + order.BeverageQuantity);
                Console.WriteLine("Beverage Price: " + order.BeveragePrice);
                Console.WriteLine("Additions:");
                foreach (var addition in order.Additions)
                {
                    Console.WriteLine("Addition Name: " + addition.AdditionName);
                    Console.WriteLine("Addition Price: " + addition.AdditionPrice);
                    Console.WriteLine("Addition Quantity: " + addition.AdditionQuantity);
                }
                Console.WriteLine();
            }
        }

        private static int GetAdditionQuantity()
        {
            int additionQuantity;
            string additionQuantityStr = Console.ReadLine();
            while (!int.TryParse(additionQuantityStr, out additionQuantity))
            {
                Console.WriteLine("Quantity is invalid! Please check and enter again:");
                additionQuantityStr = Console.ReadLine();
            }

            return additionQuantity;
        }

        private static string GetAdditionType()
        {
            string additionType = Console.ReadLine();
            while (string.IsNullOrEmpty(additionType) || additionFactory.GetBeverageType(additionType) == AdditionType.none && additionType != "-1")
            {
                Console.WriteLine("Addition type is empty or invalid! Please check and enter again:");
                additionType = Console.ReadLine();
            }

            return additionType;
        }

        private static int GetBeverageQuantity()
        {
            int beverageQuantity;
            string beverageQuantityStr = Console.ReadLine();
            while (!int.TryParse(beverageQuantityStr, out beverageQuantity))
            {
                Console.WriteLine("Quantity is invalid! Please check and enter again:");
                beverageQuantityStr = Console.ReadLine();
            }

            return beverageQuantity;
        }

        private static void DisplayBeverages()
        {
            var query = Enum.GetValues(typeof(BeverageType))
                        .Cast<BeverageType>()
                        .Except(new BeverageType[] { BeverageType.none });
            foreach (var beverageName in query)
            {
                Console.WriteLine("{0,-5}{1,-12}{2,5}{3,1}{4,7}", "For: ", beverageName, " Enter: ", (int)beverageName, " below.");
            }
        }

        private static string GetBeverageType()
        {
            string beverageType = Console.ReadLine();
            while (string.IsNullOrEmpty(beverageType) || beverageFactory.GetBeverageType(beverageType) == BeverageType.none)
            {
                Console.WriteLine("Beverage type is empty or invalid! Please check and enter again:");
                beverageType = Console.ReadLine();
            }

            return beverageType;
        }

        private static void DisplayAdditions()
        {
            var query = Enum.GetValues(typeof(AdditionType))
                        .Cast<AdditionType>()
                        .Except(new AdditionType[] { AdditionType.none });
            foreach (var additionName in query)
            {
                Console.WriteLine("{0,-5}{1,-15}{2,5}{3,1}{4,7}", "For: ", additionName, " Enter: ", (int)additionName, " below.");
            }
            Console.WriteLine();
        }
    }
}

using CoffeeShopOrder.Core.Enum;
using CoffeeShopOrder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.ConsoleUI.Helper
{
    public static class Display
    {
        public static void DisplayBeverages()
        {
            var query = Enum.GetValues(typeof(BeverageType))
                        .Cast<BeverageType>()
                        .Except(new BeverageType[] { BeverageType.none });
            foreach (var beverageName in query)
            {
                Console.WriteLine("{0,-5}{1,-12}{2,5}{3,1}{4,7}", "For: ", beverageName, " Enter: ", (int)beverageName, " below.");
            }
        }

        public static void DisplayMockedOrder(IOrder cart)
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
        public static void DisplayAdditions()
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

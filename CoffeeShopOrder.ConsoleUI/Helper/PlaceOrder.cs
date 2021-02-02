using CoffeeShopOrder.Business.Facade;
using CoffeeShopOrder.Business.Factory;
using CoffeeShopOrder.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.ConsoleUI.Helper
{
    public class PlaceOrder
    {
        static readonly OrderManagement orderManagement = new OrderManagement();
        static readonly IBeverageFactory beverageFactory = new BeverageFactory();
        static readonly IAdditionFactory additionFactory = new AdditionFactory();
        public void PlaceMockedOrder()
        {
            //Displays all available beverages
            Console.WriteLine("{0,-20}\n", "Available Bavareges:");
            //foreach (var beverageName in GetBeverages.GetAllBeverages())
            Display.DisplayBeverages();

            Console.WriteLine();

            //Display all available additions
            Console.WriteLine("{0,-20}\n", "Available Additions:");
            Display.DisplayAdditions();

            Console.WriteLine("What's your choice of beverage?");
            string beverageType = GetUserInput.GetBeverageType();

            Console.WriteLine("How many of beverages would you like?");
            int beverageQuantity = GetUserInput.GetBeverageQuantity();

            Console.WriteLine("What's your choice of addition?");
            Console.WriteLine("Enter -1 in case no addition is desired.");
            string additionType = GetUserInput.GetAdditionType();

            int additionQuantity = 0;
            if (additionType != "-1")
            {
                Console.WriteLine("How many of additions would you like?");
                additionQuantity = GetUserInput.GetAdditionQuantity();
            }

            var cart = orderManagement.PlaceOrder(beverageFactory.GetBeverageType(beverageType), beverageQuantity, additionFactory.GetBeverageType(additionType), additionQuantity);

            ////Displays mocked order
            Console.WriteLine("Ordered Beverages:");
            Display.DisplayMockedOrder(cart);

            //Displays current total for the placed order
            Console.WriteLine("Total amount: " + cart.GetTotalPrice());
            Console.WriteLine("<---------------------------------------------------------------------------------->");
        }

    }
}

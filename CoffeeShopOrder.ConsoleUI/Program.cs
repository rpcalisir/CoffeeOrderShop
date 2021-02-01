using CoffeeShopOrder.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.ConsoleUI
{

    class Program
    {
        static readonly OrderCart cart = new OrderCart();
        static readonly OrderCart available = new OrderCart();

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

            //Mocking a sample order from the user
            PopulateCart.PopulateCartWithSampleData(cart);

            //Displays mocked order
            Console.WriteLine("Ordered beverages:");
            foreach (var item in cart.Items) 
            {
                Console.WriteLine("Beverage:");
                Console.WriteLine("Beverage Name: " + item.BeverageName);
                Console.WriteLine("Beverage Quantity: " + item.BeverageQuantity);
                Console.WriteLine("Beverage Price: " + item.BeveragePrice);
                Console.WriteLine("Additions:");
                foreach (var addition in item.Additions)
                {
                    Console.WriteLine("Addition Name: " + addition.AdditionName);
                    Console.WriteLine("Addition Price: " + addition.AdditionPrice);
                    Console.WriteLine("Addition Quantity: " + addition.AdditionQuantity);
                }
                Console.WriteLine();
            }

            //Displays current total for the placed order
            Console.WriteLine("Total cost: " + cart.GetTotalPrice());

            Console.ReadLine();
        }
    }
}

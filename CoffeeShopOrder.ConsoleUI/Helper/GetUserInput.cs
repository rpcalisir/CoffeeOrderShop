using CoffeeShopOrder.Business.Factory;
using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.Core.Enum;
using System;

namespace CoffeeShopOrder.ConsoleUI.Helper
{
    public static class GetUserInput
    {
        static readonly IAdditionFactory additionFactory = new AdditionFactory();
        static readonly IBeverageFactory beverageFactory = new BeverageFactory();

        public static int GetBeverageQuantity()
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
        public static int GetAdditionQuantity()
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

        public static string GetAdditionType()
        {
            string additionType = Console.ReadLine();
            while (string.IsNullOrEmpty(additionType) || additionFactory.GetBeverageType(additionType) == AdditionType.none && additionType != "-1")
            {
                Console.WriteLine("Addition type is empty or invalid! Please check and enter again:");
                additionType = Console.ReadLine();
            }

            return additionType;
        }

        public static string GetBeverageType()
        {
            string beverageType = Console.ReadLine();
            while (string.IsNullOrEmpty(beverageType) || beverageFactory.GetBeverageType(beverageType) == BeverageType.none)
            {
                Console.WriteLine("Beverage type is empty or invalid! Please check and enter again:");
                beverageType = Console.ReadLine();
            }

            return beverageType;
        }
    }
}

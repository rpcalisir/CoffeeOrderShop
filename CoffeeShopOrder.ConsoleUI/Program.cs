﻿using CoffeeShopOrder.Business.Facade;
using CoffeeShopOrder.Business.Factory;
using CoffeeShopOrder.Business.Interface;
using CoffeeShopOrder.ConsoleUI.Helper;
using CoffeeShopOrder.Core.Enum;
using System;

namespace CoffeeShopOrder.ConsoleUI
{
    class Program
    {
        //static readonly OrderManagement orderManagement = new OrderManagement();
        //    static readonly IBeverageFactory beverageFactory = new BeverageFactory();
        //    static readonly IAdditionFactory additionFactory = new AdditionFactory();

        static void Main(string[] args)
        {
            PlaceOrder placeOrder = new PlaceOrder();

            Console.WriteLine("Press enter to place a new order:");
            Console.WriteLine("Press -1 to finish order:");
            string entry = Console.ReadLine();
            while (entry!="-1")
            {
                placeOrder.PlaceMockedOrder();
                Console.WriteLine();
                Console.WriteLine("Press enter to place a new order:");
                Console.WriteLine("Press -1 to finish order:");
                entry = Console.ReadLine();
            }

            CheckTotalPriceWithAddition(1);
            CheckTotalPriceWithoutAddition(2);

            Console.ReadLine();
        }
        private static void CheckTotalPriceWithAddition(int testcaseNumber)
        {
            //Arrange
            OrderManagement orderManagement = new OrderManagement();

            var cart = orderManagement.PlaceOrder(BeverageType.blackCoffee, 1, AdditionType.chocolateSauce, 1);

            //Act
            decimal actual = cart.GetTotalPrice();
            decimal expected = 9;

            //Assert
            string result = expected == actual ? "SUCCESS" : "FAIL";
            Console.WriteLine("TestCase" + testcaseNumber + ": " + result);
        }

        private static void CheckTotalPriceWithoutAddition(int testcaseNumber)
        {
            //Arrange
            OrderManagement orderManagement = new OrderManagement();
            var cart = orderManagement.PlaceOrder(BeverageType.blackCoffee, 1, AdditionType.none, 0);

            //Act
            decimal actual = cart.GetTotalPrice();
            decimal expected = 5;

            //Assert
            string result = expected == actual ? "SUCCESS" : "FAIL";
            Console.WriteLine("TestCase" + testcaseNumber + ": " + result);
        }
    }
}

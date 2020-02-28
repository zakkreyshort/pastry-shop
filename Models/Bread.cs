using System;
using System.Collections.Generic;
using Shop.Models;
using Shop;

namespace Shop.Models
{
    public class Bread
    {
        public int Amount { get; set; }

        public Bread()
        {
            Amount = 0;
        }
        public static void ViewTypes()
        {
            Console.WriteLine("Currently, we only sell loaves of a single type. Please come back soon for new flavors coming!");
            Console.WriteLine("Would you like to buy a loaf?");
            Console.WriteLine("[yes] [no]");
            string breadResponse = Console.ReadLine();
            breadResponse = breadResponse.ToLower();
            if (breadResponse == "yes")
            {
                BuyBread();
            }
            else if (breadResponse == "no")
            {
                Shop.Main();
            }
            else
            {
                Console.WriteLine("Please try again, answer not valid.");
                Console.WriteLine("-----------------------------------")
                ViewTypes();
            }

        }
        public static void BuyBread()
        {
            Console.WriteLine("Thank you for deciding to buy our delicious loaf. How many would you like?");
            Console.WriteLine("Price: $5/loaf, Buy 2 get 1 Free!");
            int breadAmount = Console.ReadLine();
            if (breadAmount == 1)
            {
                
            }
        }

    }
}
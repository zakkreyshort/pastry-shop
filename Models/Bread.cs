using System;
using System.Collections.Generic;
using Shop.Models;
using Shop;

namespace Shop.Models
{
    public class Bread
    {
        public int Amount { get; set; }
        public int Cost { get; set; }

        public Bread()
        {
            Amount = 0;
            Cost = 0;
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
                Console.WriteLine("-----------------------------------");
                ViewTypes();
            }

        }
        public static void BuyBread()
        {
            Console.WriteLine("Thank you for deciding to buy our delicious loaf. How many would you like?");
            Console.WriteLine("Price: $5/loaf, Buy 2 get 1 Free!");
            int breadAmount = Console.ReadLine();
            if (breadAmount == 0)
            {
                Console.WriteLine("Oh no! This must be an error, you are here to BUY bread:)");
                Console.WriteLine("-----------------------------------");
                BuyBread();
            }
            else if (breadAmount%2 == 0)
            {
                Bread.Cost = (breadAmount * 5);
                breadAmount = (breadAmount += 1);
                Amount = breadAmount;
                Console.WriteLine("You want to buy " + Bread.Amount + " loaves of bread?");
                Console.WriteLine("[yes] [no]");
                string acceptBreadAmount = Console.ReadLine();
                acceptBreadAmount = acceptBreadAmount.ToLower();
                if (acceptBreadAmount == "yes")
                {
                    Console.WriteLine("Your final cost will be " + Bread.Cost);
                    Console.WriteLine("Thank you for shopping with us!");
                }
                else if (acceptBreadAmount == "no")
                {
                    Console.WriteLine("Okay, lets start over.");
                    Console.WriteLine("-----------------------------------");
                    BuyBread();
                }

            }
            else if (breadAmount == even)
            {
                //buy one get one freeeeeeee
            }
        }

    }
}
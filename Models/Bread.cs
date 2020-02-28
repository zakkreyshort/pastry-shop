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

        public void AddLoaves(int amount)
        {
            Amount += amount;
        }
        public void ViewTypes()
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
                Program.Main();
            }
            else
            {
                Console.WriteLine("Please try again, answer not valid.");
                Console.WriteLine("-----------------------------------");
                ViewTypes();
            }

        }
        public int BuyBread()
        {
         Bread breads = new Bread();   
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
                breads.Cost = (breadAmount * 5);
                int breadAmount = (breadAmount += 1);
                int Amount = AddLoaves(breadAmount);
                Console.WriteLine("You want to buy " + breads.Amount + " loaves of bread?");
                Console.WriteLine("[yes] [no]");
                string acceptBreadAmount = Console.ReadLine();
                acceptBreadAmount = acceptBreadAmount.ToLower();
                if (acceptBreadAmount == "yes")
                {
                    Console.WriteLine("Your final cost will be " + breads.Cost);
                    Console.WriteLine("Thank you for shopping with us!");
                }
                else if (acceptBreadAmount == "no")
                {
                    Console.WriteLine("Okay, lets start over.");
                    Console.WriteLine("-----------------------------------");
                    BuyBread();
                }
            }
            else if (breadAmount == 1)
            {
                breads.Cost = 5;
                Amount = breadAmount;
                Console.WriteLine("You want to buy " + breads.Amount + " loaf of bread?");
                Console.WriteLine("[yes] [no]");
                string acceptBreadAmount2 = Console.ReadLine();
                acceptBreadAmount2 = acceptBreadAmount2.ToLower();
                if (acceptBreadAmount2 == "yes")
                {
                    Console.WriteLine("Your final cost will be " + breads.Cost);
                    Console.WriteLine("Thank you for shopping with us!");
                }
                else if (acceptBreadAmount2 == "no")
                {
                    Console.WriteLine("Okay, lets start over.");
                    Console.WriteLine("-----------------------------------");
                    BuyBread();
                }  
            }
        }
    }
}
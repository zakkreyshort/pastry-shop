using System;
using System.Collections.Generic;
using Shop.Models;
using Shop;

namespace Shop.Models
{
    public class Pastry
    {
        public int Amount { get; set;}

        public Pastry()
        {
            Amount = 0;
        }

        public void AddAmount(int amount)
        {
            Amount += amount; 
        }
    
        public void BuyPastry()
        {
            Console.WriteLine("How many pastries would you like to buy?");
            string pastryAmout = Console.ReadLine();
            int totalPastry = int.Parse(pastryAmout);
            AddAmount(totalPastry);
            Console.WriteLine("You would like to purchase " + totalPastry + " pastries?");
            Console.WriteLine("[yes] [no]");
            string buyAnswer = Console.ReadLine();
            buyAnswer = buyAnswer.ToLower();
            if(buyAnswer == "no")
            {
                Console.WriteLine("okay lets start again");
                BuyPastry();
            }
            else if (buyAnswer == "yes")
            {
                Console.WriteLine("Okay great! Your total is:");
                int totalPrice = (totalPastry/2);
                int finalCost = ((2*totalPastry)-(totalPrice * 2 - 1));
                Console.WriteLine("$" + finalCost);
                Console.WriteLine("Thank you for shopping with us!");
            }
        }
        public void ListSpecial()
        {
            Console.WriteLine("Our special today for pastry sweets is buy 1 for $2 or 3 for $5!");
        }
    }
}
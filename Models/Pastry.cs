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
                int totalPrice = ((totalPastry/3)*2+ totalPastry%3);
                int finalCost = (totalPrice * 5);
                Console.WriteLine("$" + finalCost);
            }
        }
        
    }
}
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
        }
        
    }
}
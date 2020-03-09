using System;
using System.Collections.Generic;
using Shop.Models;
using Shop;

namespace Shop.Models
{
  public class Bread
  {
  	public static Order order = new Order();
      public int Amount { get; set;}
      public Bread()
      {
        Amount = 0;
      }

      public void AddAmount(int amount)
      {
        Amount += amount; 
      }

      public void IncrementBread(int amount)
      {
        order.Pastries += amount;
      }

      public void BuyBread()
      {
		Console.WriteLine("How many rolls would you like to buy?");
		string breadAmout = Console.ReadLine();
		int totalBread = int.Parse(breadAmout);
		AddAmount(totalBread);
		Order.addOrder(totalBread);
		Console.WriteLine("You would like to purchase " + totalBread + " rolls?");
		Console.WriteLine("[yes] [no]");
		string buyAnswer = Console.ReadLine();
		buyAnswer = buyAnswer.ToLower();

			if(buyAnswer == "no")
			{
				Console.WriteLine("okay lets start again");
				BuyBread();
			}
			
			else if (buyAnswer == "yes")
			{
				Console.WriteLine("Okay great! Your total is:");
				Console.WriteLine("$" + order.Total);
				int totalPrice = ((totalBread/3)*2+ totalBread%3);
				int finalCost = (totalPrice * 5);
				Console.WriteLine("Would you like to buy more? [yes] [no]");
				string userAnswer2 = Console.ReadLine();
				if (userAnswer2 == "no")
				{
				Console.WriteLine("Your total currently is;");
				Console.WriteLine("$" + order.Total);
				Console.WriteLine("Thank you for shopping with us!");
				IncrementBread(totalBread);
				Console.WriteLine("-------------------------");
				}
				else if (userAnswer2 == "yes")
				{
					Program.Main();
				}
			}
		}
		public void ListSpecial()
		{
			Console.WriteLine("Our special today for bread rolls is buy 2 get 1 free!");
			Console.WriteLine("------------------------------------------");
			Program.Main();
		}
		public void ListMenu()
		{
			Console.WriteLine("We serve pastries and rolls!");
			Console.WriteLine("------------------------------");
			Program.Main();
		}   
  }
}


using System;
using System.Collections.Generic;
using Shop.Models;

namespace Shop
{
	public class Program
	{
	
		public static void Main()
		{
			Console.WriteLine("Hello, and welcome to my bakery!");
			Console.WriteLine("Our special today is buy 2, get 1 free bread rolls and 1 for $2 or 3 for $5 pastries");
			Console.WriteLine("What would you like to buy?");
			Console.WriteLine("[bread] [pastry] [checkout]");
			string buySomething = Console.ReadLine();

			if(buySomething == "bread")
			{
				Console.WriteLine("How many bread rolls would you like?");
				int customerBread = int.Parse(Console.ReadLine());
				Bread.FinalBreadPrice(customerBread);
				Console.WriteLine("You added " + Bread.BreadAmount + " loaves to your cart");
				Main();
			}
			else if(buySomething == "pastry")
			{
				Console.WriteLine("How many sweet rolls would you like?");
				int customerSweets = int.Parse(Console.ReadLine());
				Pastry.FinalPastryPrice(customerSweets);
				Console.WriteLine("You added " + Pastry.PastryAmount + " loaves to your cart");
				Main();
			}
			else if (buySomething == "checkout")
			{
				Console.WriteLine("Your total is:" + " $" + (Pastry.PastryPrice+Bread.BreadPrice));
				Console.WriteLine("Thank you for shopping with us!");
			}
			else
			{
				Console.WriteLine("You entered something wrong! Please try again");
				Console.WriteLine("--------------------------------------");
				Main();
			}
		}
	}	
}
	

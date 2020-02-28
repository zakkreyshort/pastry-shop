using System;
using System.Collections.Generic;
using Shop.Models;

namespace Shop
{
	public class Program
	{
		public static Pastry sweet = new Pastry();
		public static Bread roll = new Bread();
		public static void Main()
		{
			Console.WriteLine("Hi! Welcome to Pierre's Bakery!");
			Console.WriteLine("What would you like to do today");
			Console.WriteLine("Buy:[bread] [pastry] View: [menu] [specials]");
			string response = Console.ReadLine();
			response = response.ToLower();
			if (response == "pastry")
			{
				Console.WriteLine("Would you like to view types or go right to order form?");
				Console.WriteLine("[buy]");
				string optionBread = Console.ReadLine();
				if (optionBread == "buy")
				{
					sweet.BuyPastry();
				}
			}
			else if (response == "bread")
			{
				roll.BuyBread();
			}
			else if (response == "menu")
			{

			}
			else if (response == "specials")
			{

			}
			else
			{
				Console.WriteLine("Sorry, that is not an option, try again.");
				Main();
			}
		}
	}
}
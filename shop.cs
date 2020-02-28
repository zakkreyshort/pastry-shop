using System;
using System.Collections.Generic;

namespace Shop
{
	public class Program
	{
		public static Bread roll = new Bread();
		public static Pastry sweet = new Pastry();
		public static void Main()
		{
			Console.WriteLine("Hi! Welcome to Pierre's Bakery!");
			Console.WriteLine("What would you like to do today");
			Console.WriteLine("Buy:[bread] [pastry] View: [menu] [specials]");
			string response = Console.ReadLine();
			response = response.ToLower();
			// if statement goes here with all options
		}
	public static void CreateOrder()
	{
		Console.WriteLine("We will need a name for your order. Please enter your name below:");
		string orderName = Console.ReadLine();
	}
	}

}
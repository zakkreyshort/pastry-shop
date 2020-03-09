using System;
using System.Collections.Generic;
using Shop.Models;
using Shop;

namespace Shop.Models{
  public  class Order
  {
  public static Order order = new Order();
  public int Pastries { get; set; }
  public int Bread { get; set; }
  public int Total { get; set; } = 0;
		public Order()
		{
			Pastries = 0;
			Bread = 0;
			Total = 0;
		}

		public static int addOrder(int amount)
		{
			order.Total++;
			return order.Total;
		}

		public void Checkout()
		{
			Console.WriteLine("You have a total of " + order.Total + " pastries");
		}
  }
}
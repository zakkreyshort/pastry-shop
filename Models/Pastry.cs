using System;
using System.Collections.Generic;
using Shop.Models;
using Shop;

namespace Shop.Models
{
  public class Pastry
  {
	 public static int PastryPrice { get; set; }
	 public static int PastryAmount { get; set; }
	 public static void FinalPastryPrice(int count)
	 {
		 PastryAmount = count;

		 if (PastryAmount >=3)
		 {
			PastryPrice = ((PastryAmount/3*5 + (PastryAmount %3)*2));
		 }
		 else
		 {
			 PastryPrice = PastryAmount * 2;
		 }
	 }
  }
}
using System;
using System.Collections.Generic;
using Shop.Models;
using Shop;

namespace Shop.Models
{
  public class Bread
  {
	 public static int BreadPrice { get; set; }
	 public static int BreadAmount { get; set; }
	 public static void FinalBreadPrice(int count)
	 {
		 BreadAmount = count;

		 if (BreadAmount >=3)
		 {
			 BreadPrice = ((BreadAmount-BreadAmount/3)*5);
		 }
		 else
		 {
			 BreadPrice = BreadAmount * 5;
		 }
	 }
  }
}


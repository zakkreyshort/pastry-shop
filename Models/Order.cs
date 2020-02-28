using System;
using System.Collections.Generic;
using Shop.Models;
using Shop;

namespace Shop.Models{
    public class Order
    {
        public int Pastries { get; set; }
        public int Bread { get; set; }
        public int Total { get; set; }

        public Order()
        {
            Pastries = 0;
            Bread = 0;
            Total = 0;
        }


        
    }
}
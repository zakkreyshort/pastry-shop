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
                int totalPrice = ((totalBread/3)*2+ totalBread%3);
                int finalCost = (totalPrice * 5);
                Console.WriteLine("$" + finalCost);
                Console.WriteLine("Thank you for shopping with us!");
                IncrementBread(totalBread);
                Program.Main();
            }
        }

        public void ListSpecial()
        {
            Console.WriteLine("Our special today for bread rolls is buy 2 get 1 free!");
        }
        
    }
}








// {
//     public class Bread
//     {
//         public int Amount { get; set; }
//         public int Cost { get; set; }

//         public Bread()
//         {
//             Amount = 0;
//             Cost = 0;
//         }

//         public void AddLoaves(int amount)
//         {
//             Amount += amount;
//         }

//         public void ViewTypes()
//         {
//             Console.WriteLine("Currently, we only sell loaves of a single type. Please come back soon for new flavors coming!");
//             Console.WriteLine("Would you like to buy a loaf?");
//             Console.WriteLine("[yes] [no]");
//             string breadResponse = Console.ReadLine();
//             breadResponse = breadResponse.ToLower();
//             if (breadResponse == "yes")
//             {
//                 BuyBread();
//             }
//             else if (breadResponse == "no")
//             {
//                 Program.Main();
//             }
//             else
//             {
//                 Console.WriteLine("Please try again, answer not valid.");
//                 Console.WriteLine("-----------------------------------");
//                 ViewTypes();
//             }
//         }
//         public void BuyBread()
//         {
//          Bread breads = new Bread();   
//             Console.WriteLine("Thank you for deciding to buy our delicious loaf. How many would you like?");
//             Console.WriteLine("Price: $5/loaf, Buy 2 get 1 Free!");
//             string breadAmount = Console.ReadLine();
//             int numberBreadAmount = int.Parse(breadAmount);

//             if (numberBreadAmount == 0)
//             {
//                 Console.WriteLine("Oh no! This must be an error, you are here to BUY bread:)");
//                 Console.WriteLine("-----------------------------------");
//                 BuyBread();
//             }
//             else if (numberBreadAmount%2 == 0)
//             {
//                 numberBreadAmount = (numberBreadAmount + 1);
//                 breads.Amount = AddLoaves(numberBreadAmount);
//                 breads.Cost = (numberBreadAmount * 5);
//                 Console.WriteLine("You want to buy " + breads.Amount + " loaves of bread?");
//                 Console.WriteLine("[yes] [no]");
//                 string acceptBreadAmount = Console.ReadLine();
//                 acceptBreadAmount = acceptBreadAmount.ToLower();
//                 if (acceptBreadAmount == "yes")
//                 {
//                     Console.WriteLine("Your final cost will be " + breads.Cost);
//                     Console.WriteLine("Thank you for shopping with us!");
//                 }
//                 else if (acceptBreadAmount == "no")
//                 {
//                     Console.WriteLine("Okay, lets start over.");
//                     Console.WriteLine("-----------------------------------");
//                     BuyBread();
//                 }
//             }
//             else if (numberBreadAmount == 1)
//             {
//                 breads.Cost = 5;
//                 Amount = numberBreadAmount;
//                 Console.WriteLine("You want to buy " + breads.Amount + " loaf of bread?");
//                 Console.WriteLine("[yes] [no]");
//                 string acceptBreadAmount2 = Console.ReadLine();
//                 acceptBreadAmount2 = acceptBreadAmount2.ToLower();
//                 if (acceptBreadAmount2 == "yes")
//                 {
//                     Console.WriteLine("Your final cost will be " + breads.Cost);
//                     Console.WriteLine("Thank you for shopping with us!");
//                 }
//                 else if (acceptBreadAmount2 == "no")
//                 {
//                     Console.WriteLine("Okay, lets start over.");
//                     Console.WriteLine("-----------------------------------");
//                     BuyBread();
//                 }  
//             }
//         }
//     }
// }
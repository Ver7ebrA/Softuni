using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<IBuyer> buyers = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] buyersArg = Console.ReadLine().Split();

                if (buyersArg.Length == 4)
                {
                    Citizen citizen = new Citizen(buyersArg[0], int.Parse(buyersArg[1]), buyersArg[2], buyersArg[3]);
                    buyers.Add(citizen);
                }
                else if (buyersArg.Length == 3)
                {
                    Rebel rebel = new Rebel(buyersArg[0], int.Parse(buyersArg[1]), buyersArg[2]);
                    buyers.Add(rebel);
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                IBuyer buyer = buyers.Where(b => b.Name == command).FirstOrDefault();

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }

            int foodPurchased = 0;
            foreach (var buyer in buyers)
            {
                foodPurchased += buyer.Food;               
            }

            Console.WriteLine(foodPurchased);
        }
    }
}

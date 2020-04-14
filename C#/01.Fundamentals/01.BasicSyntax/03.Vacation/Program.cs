using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            double totalPrice = peopleCount * price;

            if (groupType == "Students" && 30 <= peopleCount)
            {
                totalPrice *= 0.85;
            }

            if (groupType == "Business" && 100 <= peopleCount)
            {
                totalPrice -= (10 * price);
            }

            if (groupType == "Regular" && 10 <= peopleCount && peopleCount <= 20)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}

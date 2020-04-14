using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] inputArr = input.Split();

                string serialNumber = inputArr[0];
                string itemName = inputArr[1];
                int itemQuantity = int.Parse(inputArr[2]);
                decimal itemPrice = decimal.Parse(inputArr[3]);

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.Quantity = itemQuantity;
                box.PriceBox = box.Item.Price * box.Quantity;

                boxes.Add(box);

                input = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(p => p.PriceBox).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public string  SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceBox { get; set; }
    }
}

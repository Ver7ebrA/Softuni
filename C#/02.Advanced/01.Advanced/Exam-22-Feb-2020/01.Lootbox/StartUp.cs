using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] firstLootboxItems = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int[] secondLootboxItems = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> firstLootbox = new Queue<int>();
            Stack<int> secondLootbox = new Stack<int>();

            int itemsQuality = 0;

            for (int i = 0; i < firstLootboxItems.Length; i++)
            {
                firstLootbox.Enqueue(firstLootboxItems[i]);
            }

            for (int i = 0; i < secondLootboxItems.Length; i++)
            {
                secondLootbox.Push(secondLootboxItems[i]);
            }

            while (0 < firstLootbox.Count && 0 < secondLootbox.Count)
            {
                int firstItem = firstLootbox.Peek();
                int secondItem = secondLootbox.Pop();

                if ((firstItem + secondItem) % 2 == 0)
                {
                    itemsQuality += firstItem + secondItem;
                    firstLootbox.Dequeue();
                }
                else
                {
                    firstLootbox.Enqueue(secondItem);
                }
            }

            if (firstLootbox.Count <= 0)
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (secondLootbox.Count <= 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (100 <= itemsQuality)
            {
                Console.WriteLine($"Your loot was epic! Value: {itemsQuality}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {itemsQuality}");
            }
        }
    }
}

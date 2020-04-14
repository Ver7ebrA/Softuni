using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> numbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(numbers1.Count, numbers2.Count); i++)
            {
                result.Add(numbers1[i]);
                result.Add(numbers2[i]);
            }

            if (numbers1.Count < numbers2.Count)
            {
                result.AddRange(GetRemainingElements(numbers1, numbers2));
            }
            else
            {
                result.AddRange(GetRemainingElements(numbers2, numbers1));
            }

            Console.WriteLine(String.Join(" ", result));
        }

        static List<int> GetRemainingElements(List<int> shorterList, List<int> longerList)
        {
            List<int> nums = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                nums.Add(longerList[i]);
            }

            return nums;
        }
    }
}

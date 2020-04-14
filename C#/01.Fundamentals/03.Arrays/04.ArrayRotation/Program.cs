using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] arr2 = new int[arr1.Length];
                arr2[arr2.Length - 1] = arr1[0];

                for (int j = 0; j < arr2.Length -1; j++)
                {
                    arr2[j] = arr1[j + 1];
                }

                arr1 = arr2;
            }

            Console.WriteLine(string.Join(" ", arr1));
        }
    }
}

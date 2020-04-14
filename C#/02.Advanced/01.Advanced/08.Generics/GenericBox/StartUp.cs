using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Box<double>> boxList = new List<Box<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                Box<double> box = new Box<double>(input);
                boxList.Add(box);
            }

            double element = double.Parse(Console.ReadLine());

            Console.WriteLine(CountGreaterElements(boxList, element));
        }

        static int CountGreaterElements<T>(List<Box<T>> list, T element)
            where T : IComparable<T>
        {
            int counter = 0;

            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}

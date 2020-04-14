using System;

namespace _06.CalculateAreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, heigth);
            Console.WriteLine(area);
        }

        static double GetRectangleArea(double width, double heigth)
        {
            return width * heigth;
        }
    }
}

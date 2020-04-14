using System;

namespace ThreeupleEx
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            Threeuple<string, string, string> firstThreeuple = new Threeuple<string, string, string>(
                firstInput[0] + " " + firstInput[1],
                firstInput[2],
                firstInput[3]);
            Console.WriteLine(firstThreeuple);

            string[] secondInput = Console.ReadLine().Split();
            Threeuple<string, int, bool> secondThreeuple = new Threeuple<string, int, bool>(
                secondInput[0],
                int.Parse(secondInput[1]),
                secondInput[2] == "drunk" ? true : false);
            Console.WriteLine(secondThreeuple);

            string[] thirdInput = Console.ReadLine().Split();
            Threeuple<string, double, string> thirdThreeuple = new Threeuple<string, double, string>(
                thirdInput[0],
                double.Parse(thirdInput[1]),
                thirdInput[2]);
            Console.WriteLine(thirdThreeuple);
        }
    }
}

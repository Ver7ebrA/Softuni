using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsabreMoney = (Math.Ceiling(1.1 * students)) * lightsabrePrice;
            double robeMoney = students * robePrice;
            double beltMoney = (students - (students / 6)) * beltPrice;

            double moneyNeeded = lightsabreMoney + robeMoney + beltMoney;

            if (moneyNeeded <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(moneyNeeded - money):f2}lv more.");
            }
        }
    }
}

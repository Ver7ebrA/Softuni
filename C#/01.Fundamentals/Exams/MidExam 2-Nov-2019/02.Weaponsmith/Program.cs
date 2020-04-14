using System;
using System.Linq;

namespace _02.Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weaponName = Console.ReadLine().Split("|").ToArray();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandArr = command.Split().ToArray();

                if (commandArr[0] == "Move")
                {
                    int index = int.Parse(commandArr[2]);

                    if (commandArr[1] == "Left")
                    {
                        if (1 <= index && index < weaponName.Length)
                        {
                            string elementToMoveLeft = weaponName[index];
                            string elementToMoveRigth = weaponName[index - 1];

                            weaponName[index - 1] = elementToMoveLeft;
                            weaponName[index] = elementToMoveRigth;
                        }
                    }
                    else if (commandArr[1] == "Right")
                    {
                        if (0 <= index && index < weaponName.Length - 1)
                        {
                            string elementToMoveLeft = weaponName[index + 1];
                            string elementToMoveRigth = weaponName[index];

                            weaponName[index + 1] = elementToMoveRigth;
                            weaponName[index] = elementToMoveLeft;
                        }
                    }
                }
                else if (commandArr[0] == "Check")
                {
                    if (commandArr[1] == "Even")
                    {
                        for (int i = 0; i < weaponName.Length; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(weaponName[i] + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (commandArr[1] == "Odd")
                    {
                        for (int i = 0; i < weaponName.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(weaponName[i] + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine();
            }

            string finishedWeapon = string.Empty;
            foreach (string element in weaponName)
            {
                finishedWeapon += element.ToString().Trim();
            }
            Console.WriteLine($"You crafted {finishedWeapon}!");
        }
    }
}

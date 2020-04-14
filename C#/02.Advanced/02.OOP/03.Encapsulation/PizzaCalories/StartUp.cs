using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaArg = Console.ReadLine().Split();
                Pizza pizza = new Pizza(pizzaArg[1]);

                string[] doughArg = Console.ReadLine().Split();
                Dough dough = new Dough(doughArg[1], doughArg[2], int.Parse(doughArg[3]));

                pizza.Dough = dough;

                string command = Console.ReadLine();

                while (command.ToUpper() != "END")
                {
                    string[] toppingArg = command.Split();
                    Topping topping = new Topping(toppingArg[1], int.Parse(toppingArg[2]));
                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);               
            }         
        }
    }
}

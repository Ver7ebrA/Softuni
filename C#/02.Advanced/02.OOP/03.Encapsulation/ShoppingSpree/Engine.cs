using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingSpree
{
    public class Engine
    {
        public void Run()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var pair in peopleInput)
            {
                string[] peopleArg = pair.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = peopleArg[0];
                decimal money = decimal.Parse(peopleArg[1]);

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var pair in productsInput)
            {
                string[] productArg = pair.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = productArg[0];
                decimal cost = decimal.Parse(productArg[1]);

                try
                {
                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = commandArg[0];
                string productName = commandArg[1];

                Person person = people.First(p => p.Name == personName);
                Product product = products.First(p => p.Name == productName);

                Shopping(person, product);

                command = Console.ReadLine();
            }

            PrintOutput(people);
        }

        private static void PrintOutput(List<Person> people)
        {
            foreach (var person in people)
            {
                if (person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {String.Join(", ", person.BagOfProducts.Select(p => p.Name))}");
                }
            }
        }

        private static void Shopping(Person person, Product product)
        {
            bool boughtProduct = person.BuyProduct(product);

            if (boughtProduct)
            {
                Console.WriteLine($"{person.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{person.Name} can't afford {product.Name}");
            }
        }
    }   
}

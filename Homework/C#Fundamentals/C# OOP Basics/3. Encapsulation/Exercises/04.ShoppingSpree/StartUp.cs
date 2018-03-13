using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ShoppingSpree
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                List<Person> people = ParsePeople();
                List<Product> products = ParseProducts();

                BuyProducts(people, products);

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void BuyProducts(List<Person> people, List<Product> products)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split();
                string personName = tokens[0];
                string productName = tokens[1];

                Person person = people.First(p => p.Name == personName);

                Product product = products.First(p => p.Name == productName);

                string output = person.TryBuyProduct(product);
                Console.WriteLine(output);
            }
        }

        private static List<Product> ParseProducts()
        {
            string[] productsInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);


            List<Product> products = new List<Product>();

            foreach (var productInput in productsInput)
            {
                string[] tokens = productInput.Split('=');
                string productName = tokens[0];
                decimal productPrice = decimal.Parse(tokens[1]);

                Product product = new Product(productName, productPrice);

                products.Add(product);
            }

            return products;
        }

        private static List<Person> ParsePeople()
        {
            string[] peopleInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();

            foreach (var personInput in peopleInput)
            {
                string[] tokens = personInput.Split('=');
                string personName = tokens[0];
                decimal personMoney = decimal.Parse(tokens[1]);

                Person person = new Person(personName, personMoney);
                people.Add(person);
            }

            return people;
        }
    }
}

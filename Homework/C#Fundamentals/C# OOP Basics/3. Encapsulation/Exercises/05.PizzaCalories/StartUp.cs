using System;

namespace _05.PizzaCalories
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string pizzaName = Console.ReadLine().Split()[1];
                Pizza pizza = new Pizza(pizzaName);

                Dough dough = CreateDougt();

                pizza.SetDough(dough);

                string command;

                while ((command = Console.ReadLine()) != "END")
                {
                    CreateTopping(pizza, command);
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static Dough CreateDougt()
        {
            string[] doughInput = Console.ReadLine().Split();

            string flourType = doughInput[1];
            string bakingTechnique = doughInput[2];
            double doughWeight = double.Parse(doughInput[3]);

            Dough dough = new Dough(flourType, bakingTechnique, doughWeight);
            return dough;
        }

        private static void CreateTopping(Pizza pizza, string command)
        {
            string[] toppingInput = command.Split();
            string toppingType = toppingInput[1];
            double toppingWeight = double.Parse(toppingInput[2]);

            Topping topping = new Topping(toppingType, toppingWeight);
            pizza.AddToppings(topping);
        }
    }
}

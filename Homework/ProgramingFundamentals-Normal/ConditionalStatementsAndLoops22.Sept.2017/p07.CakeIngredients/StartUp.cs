
namespace p07.CakeIngredients
{
    using System;

   public class StartUp
    {
        public static void Main()
        {
            string ingredient = "";

            for (int i = 0; ; i++)
            {
                ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }

            }
        }
    }
}

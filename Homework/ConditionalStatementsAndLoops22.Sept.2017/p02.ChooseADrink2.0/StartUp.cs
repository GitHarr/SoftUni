namespace p02.ChooseADrink2._0
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (profession == "Athlete")
            {
                price = quantity * 0.7;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = quantity * 1.0;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                price = quantity * 1.7;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else
            {
                price = quantity * 1.2;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
        }
    }
}

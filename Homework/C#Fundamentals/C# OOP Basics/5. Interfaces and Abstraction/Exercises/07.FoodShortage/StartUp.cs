using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FoodShortage
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    Citizen citizen = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                    citizens.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                    rebels.Add(rebel);
                }
            }

            List<IBuyer> buyers = new List<IBuyer>();

            string nameInput;
            while ((nameInput = Console.ReadLine()) != "End")
            {
                foreach (var citizen in citizens.Where(c => c.Name == nameInput))
                {
                    citizen.BuyFood();
                    if (!buyers.Contains(citizen))
                    {
                        buyers.Add(citizen); 
                    }
                }

                foreach (var rebel in rebels.Where(r => r.Name == nameInput))
                {
                    rebel.BuyFood();
                    if (!buyers.Contains(rebel))
                    {
                        buyers.Add(rebel);
                    }
                }
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}

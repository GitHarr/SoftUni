using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> carsInfo = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Car car = new Car();
                string[] input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                car.Model = input[0];
                car.FuelAmount = double.Parse(input[1]);
                car.FuelConsumPer1km = double.Parse(input[2]);
                car.DistanceTraveled = 0;

                carsInfo.Add(car);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string carModel = tokens[1];
                int amountOfKm = int.Parse(tokens[2]);

                foreach (var car in carsInfo.Where(c => c.Model == carModel))
                {
                    if (car.CanMove(car.FuelAmount, car.FuelConsumPer1km, amountOfKm))
                    {
                        var usedFuel = amountOfKm * car.FuelConsumPer1km;

                        car.FuelAmount -= usedFuel;
                        car.DistanceTraveled += amountOfKm;
                    }

                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }

            foreach (var car in carsInfo)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
    }
}

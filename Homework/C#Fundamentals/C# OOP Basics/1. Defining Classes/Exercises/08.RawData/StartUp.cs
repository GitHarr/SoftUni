using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var cars = GetCars();
        PrintCars(cars);
    }

    public static void PrintCars(List<Car> cars)
    {
        string command = Console.ReadLine();

        if (command == "fragile")
        {
            foreach (var car in cars.Where(c => c.Cargo.Type == command))
            {
                if (car.Tires.Any(t => t.Pressure < 1))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }

        else if(command == "flamable")
        {
            foreach (var car in cars.Where(c => c.Cargo.Type == command))
            {
                if (car.Engine.Power > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }

    public static List<Car> GetCars()
    {
        List<Car> cars = new List<Car>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            // < Model > < EngineSpeed > < EnginePower > < CargoWeight > < CargoType > < Tire1Pressure > 
            //< Tire1Age > < Tire2Pressure > < Tire2Age > < Tire3Pressure > < Tire3Age > < Tire4Pressure > < Tire4Age > 

            Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
            Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);
            var tires = new Tires[]
            {
                    new Tires(int.Parse(input[6]), double.Parse(input[5])),
                    new Tires(int.Parse(input[8]), double.Parse(input[7])),
                    new Tires(int.Parse(input[10]), double.Parse(input[9])),
                    new Tires(int.Parse(input[12]), double.Parse(input[11])),
            };

            cars.Add(new Car(input[0], engine, cargo, tires));
        }

        return cars;
    }
}


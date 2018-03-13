using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<Car> cars = new List<Car>();
        int lines = int.Parse(Console.ReadLine());
        ParseParameters(lines, cars);

        string command = Console.ReadLine();
        if (command == "fragile")
        {
            List<string> fragile = cars
                .Where(x => x.Cargo.Type == "fragile" && x.tires.Any(y => y.Pressure < 1))
                .Select(x => x.Model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fragile));
        }
        else
        {
            List<string> flamable = cars
                .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                .Select(x => x.Model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, flamable));
        }
    }

    private static void ParseParameters(int lines, List<Car> cars)
    {
        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split();

            Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
            Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);
            var tires = new Tire[]
            {
                new Tire(double.Parse(input[5]), int.Parse(input[6])),
                new Tire(double.Parse(input[7]), int.Parse(input[8])),
                new Tire(double.Parse(input[9]), int.Parse(input[10])),
                new Tire(double.Parse(input[11]), int.Parse(input[12])),
            };

            cars.Add(new Car(input[0], engine, cargo, tires));
        }
    }
}





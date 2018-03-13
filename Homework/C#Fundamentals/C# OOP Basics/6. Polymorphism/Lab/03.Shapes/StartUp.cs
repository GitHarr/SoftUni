using System;
using System.Collections.Generic;

namespace _03.Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            var figures = new List<Shape>();

            figures.Add(new Rectangle(2.0, 2.0));
            figures.Add(new Circle(4));

            foreach (var figure in figures)
            {
                var area = figure.CalculateArea();
                var perimeter = figure.CalculatePerimeter();
                var figureType = figure.GetType().Name;

                Console.WriteLine(figure.Draw());
                Console.WriteLine($"{figure.CalculateArea():f2}");
                Console.WriteLine($"{figure.CalculatePerimeter():f2}");
            }
        }
    }
}

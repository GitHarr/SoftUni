namespace p11.GeometryCalculator
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string typeFigure = Console.ReadLine();

            PrintFigureArea(typeFigure);
        }

        public static void PrintFigureArea(string typeFigure)
        {

            if (typeFigure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{GetTriangleArea(side, height):F2}");
            }

            else if (typeFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine($"{GetSquareArea(side):F2}");
            }

            else if (typeFigure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{GetRectangleArea(width, height):F2}");
            }

            else if (typeFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                Console.WriteLine($"{GetCircleArea(radius):F2}");
            }

            Console.WriteLine();
        }

        private static double GetCircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

        private static double GetRectangleArea(double width, double height)
        {
            double area = width * height;

            return area;
        }

        private static double GetSquareArea(double side)
        {
            double area = side * side;

            return area;
        }

        private static double GetTriangleArea(double side, double height)
        {
            double area = side * height / 2;

            return area;
        }


    }
}

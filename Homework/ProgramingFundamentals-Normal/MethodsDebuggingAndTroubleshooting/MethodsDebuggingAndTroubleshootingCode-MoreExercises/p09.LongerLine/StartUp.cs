namespace p09.LongerLine
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double distanceX = GetDistBtwnTwoPoints(x1, y1, x2, y2);
            double distanceY = GetDistBtwnTwoPoints(x3, y3, x4, y4);

            if (distanceX >= distanceY)
            {
                PrintClosestCoordinates(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestCoordinates(x3, y3, x4, y4);
            }
        }

        private static double GetDistBtwnTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distX = x1 - x2;
            double distY = y1 - y2;
            double distXY = Math.Sqrt(distX * distX + distY * distY);

            return distXY;
        }

        public static void PrintClosestCoordinates(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(x1 * x1 + y1 * y1) <= Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}

namespace p04.DistanceBetweenPoints
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double distance = CalcDistance(p1, p2);

            Console.WriteLine($"Distance: {distance:F3}");
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        internal class Point
        {
            public int Y { get; internal set; }
            public int X { get; internal set; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.RectangleIntersection
{
    public class StartUp
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split();

            var rectangles = SetRectangles(int.Parse(firstLine[0]));
            CheckIntersections(int.Parse(firstLine[1]), rectangles);
        }

        private static void CheckIntersections(int numberOfIntersectionChecks, Queue<Rectangle> rectangles)
        {
            for (int i = 0; i < numberOfIntersectionChecks; i++)
            {
                var pair = Console.ReadLine().Split();
                var firstRect = rectangles.Where(r => r.Id == pair[0]).FirstOrDefault();
                var secondRect = rectangles.Where(r => r.Id == pair[1]).FirstOrDefault();

                if (firstRect.IsThereIntersection(secondRect))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        private static Queue<Rectangle> SetRectangles(int numberOfRectangles)
        {
            var rectangles = new Queue<Rectangle>(numberOfRectangles);

            while (rectangles.Count < numberOfRectangles)
            {
                var input = Console.ReadLine().Split();
                rectangles.Enqueue(new Rectangle(input[0], double.Parse(input[1]),
                    double.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4])));
            }

            return rectangles;
        }
    }
}

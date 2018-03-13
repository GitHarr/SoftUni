using System;
using System.Linq;

namespace _2.PointInRectangle
{
    public class StartUp
    {
        public static void Main()
        {
            var rectangle = new Rectangle(Console.ReadLine());

            var pointsCount = int.Parse(Console.ReadLine());

            for (int pointsCounter = 0; pointsCounter < pointsCount; pointsCounter++)
            {
                //var pointCoord = Console.ReadLine().Split().Select(int.Parse).ToList();
                //var point = new Point(pointCoord[0], pointCoord[1]);

                var point = new Point(Console.ReadLine);

                var containsPoint = rectangle.Contains(point);
                Console.WriteLine(containsPoint);
            }
        }
    }
}

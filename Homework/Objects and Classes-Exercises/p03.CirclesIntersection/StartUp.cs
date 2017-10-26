﻿namespace p03.CirclesIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstCircle = InsertTheParameters();
            var secondCircle = InsertTheParameters();

            double solutionSqrt = GetTheDistance(firstCircle, secondCircle);

            if (solutionSqrt <= firstCircle.diameter + secondCircle.diameter)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static Circle InsertTheParameters()
        {
            int[] inputParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var circleParams = new Circle()
            {
                xAxis = inputParameters[0],
                yAxis = inputParameters[1],
                diameter = inputParameters[2]
            };

            return circleParams;
        }

        private static double GetTheDistance(Circle firstPoint, Circle secondPoint)
        {
            int xDiff = (int)Math.Pow(firstPoint.xAxis - secondPoint.xAxis, 2);
            int yDiff = (int)Math.Pow(firstPoint.yAxis - secondPoint.yAxis, 2);
            double solutionSqrt = Math.Sqrt(xDiff + yDiff);
            return solutionSqrt;
        }
    }

    public class Circle
    {
        public int xAxis { get; set; }
        public int yAxis { get; set; }
        public int diameter { get; set; }
    }
}
    


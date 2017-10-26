namespace p10.CubeProperties
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            double resultByParameter = CalcCubeProperties(cubeSide);

            Console.WriteLine($"{resultByParameter:F2}");
        }

        public static double CalcCubeProperties(double cubeSide)
        {
            string parameter = Console.ReadLine();
            double result = 0.0;

            if (parameter == "face")
            {
                result = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            }
            else if (parameter == "space")
            {
                result = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            }
            else if (parameter == "volume")
            {
                result = Math.Pow(cubeSide, 3);
            }
            else
            {
                result = 6 * Math.Pow(cubeSide, 2);
            }

            return result;
        }
    }
}

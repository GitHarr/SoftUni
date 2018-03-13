using System;

namespace _01.ClassBox
{
    public class StartUp
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            double surface = box.GetSurfaceArea();
            double lateralSurface = box.GetLateralSurfaceArea();
            double volume = box.GetVolume();
            
            Console.WriteLine($"Surface Area - {surface:f2}");
            Console.WriteLine($"Lateral Surface Area - {lateralSurface:f2}");
            Console.WriteLine($"Volume - {volume:f2}");
        }
    }
}

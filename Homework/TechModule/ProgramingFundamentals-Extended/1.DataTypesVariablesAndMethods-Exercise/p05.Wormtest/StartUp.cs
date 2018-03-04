namespace p05.Wormtest
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int wormLengthInMetres = int.Parse(Console.ReadLine());
            double wormWidthInCm = double.Parse(Console.ReadLine());

            int lenthInCm = wormLengthInMetres * 100;

            double reminder = lenthInCm % wormWidthInCm;

            if (reminder > 0)
            {
                double percent = (lenthInCm / wormWidthInCm) * 100.0;
                Console.WriteLine($"{percent:F2}%");
            }

            else
            {
                double product = lenthInCm * wormWidthInCm;
                Console.WriteLine($"{product:F2}");
            }
        }
    }
}

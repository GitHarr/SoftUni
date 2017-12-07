namespace p04.Resurrection
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                decimal wingLength = decimal.Parse(Console.ReadLine());

                decimal totalWingsLength = 2 * wingLength;
                decimal poweredLength = totalLength * totalLength;
                decimal totalYears = poweredLength * (totalWidth + totalWingsLength);

                Console.WriteLine(totalYears);
            }

        }
    }
}

namespace p02.HornetWings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distancePer1000Meters = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double allDistance = (wingFlaps / 1000.0) * distancePer1000Meters;

            double distanceInSecs = wingFlaps / 100.0;
            double allRestsInSecs = (wingFlaps / endurance) * 5;

            double allSecs = Math.Floor(distanceInSecs + allRestsInSecs);

            Console.WriteLine($"{allDistance:F2} m.");
            Console.WriteLine($"{allSecs} s.");
        }
    }
}

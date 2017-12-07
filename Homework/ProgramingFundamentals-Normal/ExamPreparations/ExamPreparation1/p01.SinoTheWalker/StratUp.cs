namespace p01.SinoTheWalker
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StratUp
    {
        public static void Main()
        {
            var date = DateTime.ParseExact(Console.ReadLine(), "H:m:s", CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine());
            var timeInSeconds = int.Parse(Console.ReadLine());

            var secondsToAdd = (long)steps * timeInSeconds;

            var dayNight = 24 * 60 * 60;

            secondsToAdd = secondsToAdd % dayNight;

            var resultDate = date.AddSeconds(secondsToAdd);

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", resultDate);
        }
    }
}

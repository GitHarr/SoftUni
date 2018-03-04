namespace p01.SinoTheWalkerTheBetterWay
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
            var nums = Console.ReadLine().Split(':').Select(int.Parse).ToArray();

            long seconds = nums[2] + 60 * nums[1] + 60 * 60 * nums[0];

            var secondsToAdd = long.Parse(Console.ReadLine()) * long.Parse(Console.ReadLine());

            seconds = seconds + secondsToAdd;

            var secs = seconds % 60;

            var mins = (seconds / 60) % 60;

            var hours = (seconds / 60 / 60) % 24;

            Console.WriteLine($"Time Arrival: {hours:d2}:{mins:d2}:{secs:d2}");
        }
    }
}

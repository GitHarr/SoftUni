namespace p19.TheaThePhotographer
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int pictures = int.Parse(Console.ReadLine());
            int secondsPerPicture = int.Parse(Console.ReadLine());
            int filterPercent = int.Parse(Console.ReadLine());
            int uploadTimePerPicture = int.Parse(Console.ReadLine());

            int filterSeconds = pictures * secondsPerPicture;
            double uploadSeconds = Math.Ceiling(filterPercent / 100.0 * pictures * uploadTimePerPicture);
            int totalSeconds = filterSeconds + (int)uploadSeconds;

            int hours = 0;
            int minutes = 0;
            int days = 0;

            while (totalSeconds > 59)
            {
                totalSeconds -= 60;
                minutes++;
                if (minutes > 59)
                {
                    minutes -= 60;
                    hours++;
                }
                if (hours > 23)
                {
                    hours -= 24;
                    days++;
                }
            }
           // TimeSpan span = new TimeSpan(days, hours, minutes, totalSeconds);
            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{totalSeconds:D2}");
        }
    }
}

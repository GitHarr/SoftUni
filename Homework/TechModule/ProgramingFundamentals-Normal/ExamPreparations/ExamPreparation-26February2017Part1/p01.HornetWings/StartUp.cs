namespace p01.HornetWings
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double distanceTravelled = wingFlaps / 1000 * distance;
            Console.WriteLine($"{distanceTravelled:F2} m.");

            double timeOfBreaks = wingFlaps / endurance * 5;
            double timeTravelled = wingFlaps / 100;
            Console.WriteLine($"{(timeOfBreaks + timeTravelled)} s.");
        
        }
    }
}

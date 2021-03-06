﻿namespace p11.ConvertSpeedUnits
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            uint distanceInMeters = uint.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            ushort time = (ushort)(hours * 3600 + minutes * 60 + seconds);

            float metersPerSeconds = (float)distanceInMeters / time;
            float kilometersPerHour = ((float)distanceInMeters / 1000) / ((float)time / 3600);
            float milesPerHour = ((float)distanceInMeters / 1609) / ((float)time / 3600);

            Console.WriteLine("{0:0.#######}", metersPerSeconds);
            Console.WriteLine("{0:0.#######}", kilometersPerHour);
            Console.WriteLine("{0:0.#######}", milesPerHour);
        }
    }
}

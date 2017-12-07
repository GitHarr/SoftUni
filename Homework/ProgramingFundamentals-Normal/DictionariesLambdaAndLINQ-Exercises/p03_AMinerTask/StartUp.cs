namespace p03_AMinerTask
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, long> resoursesAndQuantities = new Dictionary<string, long>();

            while (true)
            {
                string resourse = Console.ReadLine();
                if (resourse == "stop")
                {
                    break;
                }
                long quantity = long.Parse(Console.ReadLine());

                if (!resoursesAndQuantities.ContainsKey(resourse))
                {
                    resoursesAndQuantities.Add(resourse, 0);
                }
                resoursesAndQuantities[resourse] += quantity;
            }
            foreach (var key in resoursesAndQuantities)
            {
                Console.WriteLine($"{key.Key} -> {key.Value}");
            }
        }
    }
}

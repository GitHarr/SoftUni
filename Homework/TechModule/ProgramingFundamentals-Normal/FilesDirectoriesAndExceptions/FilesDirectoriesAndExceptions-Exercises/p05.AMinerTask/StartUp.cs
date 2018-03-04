namespace p05.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");

            File.Delete("output.txt");

            Dictionary<string, long> resoursesAndQuantities = new Dictionary<string, long>();

            for (int i = 0; i < lines.Length; i+=2)
            {
                string resourse = lines[i];

                if (resourse == "stop")
                {
                    break;
                }

                long quantity = long.Parse(lines[i + 1]);

                if (!resoursesAndQuantities.ContainsKey(resourse))
                {
                    resoursesAndQuantities.Add(resourse, 0);
                }
                resoursesAndQuantities[resourse] += quantity;
            }
         
            foreach (var key in resoursesAndQuantities)
            {
                var output = $"{key.Key} -> {key.Value}" + Environment.NewLine;
                File.AppendAllText("output.txt", output);
            }
        }
    }
}

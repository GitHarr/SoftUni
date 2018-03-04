namespace p03.CameraView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {

            int[] skipTake = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skip = skipTake[0];
            int take = skipTake[1];
            
            string pattern = "\\|<(\\w{" + skip + "})(\\w{0," + take + "})";

            string input = Console.ReadLine();

            List<string> result = new List<string>();

            var matches = Regex.Matches(input, pattern);

            foreach (Match m in matches)
            {
                result.Add(m.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

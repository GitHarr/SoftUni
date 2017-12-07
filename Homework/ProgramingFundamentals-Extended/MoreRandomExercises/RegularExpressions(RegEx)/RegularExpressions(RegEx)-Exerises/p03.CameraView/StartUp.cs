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
            int[] firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skipElements = firstInput[0];
            int takeElements = firstInput[1];

            string cameraLine = Console.ReadLine();

            Regex cameraGroups = new Regex(@"\|<(\w{" + skipElements + @"})(\w{0," + takeElements + @"})");

            MatchCollection solution = cameraGroups.Matches(cameraLine);

            List<string> picsTaken = new List<string>();

            foreach (Match camera in solution)
            {
                picsTaken.Add(camera.Groups[2].Value.ToString());
            }

            Console.WriteLine(string.Join(", ", picsTaken));
        }
    }
}

namespace p04.LongestIncreasingSubsequence
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
            var inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var longestIncreasingSubsequence = FindLongestIncreasingSubsequence(inputArr);

            Console.WriteLine(string.Join(" ", longestIncreasingSubsequence));
        }

        static int[] FindLongestIncreasingSubsequence(int[] arr)
        {
            var lengths = new int[arr.Length];
            var previous = new int[arr.Length];

            var bestLenght = 0;
            var lastIndex = -1;

            for (int anchor = 0; anchor < arr.Length; anchor++)
            {
                lengths[anchor] = 1;
                previous[anchor] = -1;

                var anchorNum = arr[anchor];

                for (int i = 0; i < anchor; i++)
                {
                    var currentNum = arr[i];

                    if (currentNum < anchorNum && lengths[i] + 1 > lengths[anchor])
                    {
                        lengths[anchor] = lengths[i] + 1;
                        previous[anchor] = i;
                    }
                }

                if (lengths[anchor] > bestLenght)
                {
                    bestLenght = lengths[anchor];
                    lastIndex = anchor;
                }
            }

            var longestIncreasingSubsequence = new List<int>();

            while (lastIndex != -1)
            {
                longestIncreasingSubsequence.Add(arr[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            longestIncreasingSubsequence.Reverse();

            return longestIncreasingSubsequence.ToArray();
        }
    }
}

namespace p01.MaxSequenceOfEqualElements
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

            var maxSequenceOfEqualElements = FindMaxSequenceOfEqualElements(inputArr);

            Console.WriteLine(string.Join(" ", maxSequenceOfEqualElements));
        }

        static int[] FindMaxSequenceOfEqualElements(int[] arr)
        {
            var longestSequence = new List<int>();
            var currentSequence = new List<int>();

            currentSequence.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                var currentNum = arr[i];
                var searchNum = currentSequence[0];

                if (currentNum == searchNum)
                {
                    currentSequence.Add(currentNum);
                }

                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence);
                    }

                    currentSequence.Clear();
                    currentSequence.Add(currentNum);
                }
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence);
            }

            return longestSequence.ToArray();
        }
    }
}

namespace p07.MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int startPos = 0;
            int lenOfIncreasing = 1;
            int bestStartPos = 0;
            int bestLen = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] >= input[i - 1] + 1)
                {
                    lenOfIncreasing++;
                    if (lenOfIncreasing > bestLen)
                    {
                        bestStartPos = startPos;
                        bestLen = lenOfIncreasing;
                    }
                }
                else
                {
                    startPos = i;
                    lenOfIncreasing = 1;
                }
            }
            for (int i = bestStartPos; i < bestStartPos + bestLen; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}

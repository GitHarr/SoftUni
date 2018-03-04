namespace p06.MaxSequenceOfEqualElements
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
            int[] inputSeq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int len = 1;

            int bestStart = 0;
            int bestLen = 0;

            for (int i = 1; i < inputSeq.Length; i++)
            {
                if (inputSeq[i] == inputSeq[i - 1])
                {
                    len++;

                    if (len > bestLen)
                    {
                        bestStart = start;
                        bestLen = len;
                    }
                }

                else
                {
                    start = i;
                    len = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(inputSeq[i] + " ");
            }

            //List<int> result = new List<int>();
            //for (int i = 0; i < bestLen; i++)
            //{
            //    result.Add(bestStart);
            //}
            //Console.WriteLine(string.Join(" ", result));
        }
    }
}

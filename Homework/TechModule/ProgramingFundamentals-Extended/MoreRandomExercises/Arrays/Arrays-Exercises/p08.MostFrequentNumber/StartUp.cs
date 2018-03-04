namespace p08.MostFrequentNumber
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

            int freqNum = 0;
            int len = 0;

            int mostFreqNum = 0;
            int bestLen = 0;

            for (int i = 0; i < inputSeq.Length; i++)
            {
                for (int j = 0; j < inputSeq.Length; j++)
                {
                    if (inputSeq[j] == inputSeq[i])
                    {
                        freqNum = inputSeq[i];
                        len++;
                    }
                }

                if (len > bestLen)
                {
                    bestLen = len;
                    mostFreqNum = freqNum;
                }

                len = 0;
            }

            Console.WriteLine(mostFreqNum);
        }
    }
}

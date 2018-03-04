namespace p03.LastKNumbersSums
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] seq = new long[n];
            seq[0] = 1;

            for (long i = 0; i < seq.Length; i++)
            {
                for (long j = i - k; j < i; j++)
                {
                    try
                    {
                        seq[i] = seq[i] + seq[j];
                    }
                    catch (IndexOutOfRangeException)
                    {

                        
                    }
                }

                Console.WriteLine(seq[i]);
            }
        }
    }
}

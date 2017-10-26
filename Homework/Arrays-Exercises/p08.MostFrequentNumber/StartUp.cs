namespace p08.MostFrequentNumber
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestCount = 0;
            int mostFrequentNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    mostFrequentNumber = numbers[i];
                }
            }
            Console.WriteLine(mostFrequentNumber);
        }
    }
}

namespace p01.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int count = 1;
            int number = 0;
            int maxCount = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = numbers[i];
                    }
                }

                else
                {
                    count = 1;
                }
            }

            if (maxCount == 1)
            {
                Console.WriteLine(numbers[0]);
            }

            else
            {
                for (int i = 0; i < maxCount; i++)
                { 
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
 
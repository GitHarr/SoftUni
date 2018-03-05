using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    public class StartUp
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lowerBound = inputNums[0];
            int upperBound = inputNums[1];

            string oddOrEven = Console.ReadLine();

            Predicate<int> isEven = x => x % 2 == 0;

            Predicate<int> isOdd = x => x % 2 != 0;

            List<int> result = new List<int>();

            if (oddOrEven == "even")
            {
                for (int i = lowerBound; i <= upperBound; i++)
                {
                    if (isEven.Invoke(i))
                    {
                        result.Add(i);
                    }
                } 
            }

            else
            {
                for (int i = lowerBound; i <= upperBound; i++)
                {
                    if (isOdd.Invoke(i))
                    {
                        result.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

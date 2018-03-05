using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._List_Of_Predicates
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var divisors = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, bool> predicate = CreatePredicate(divisors);

            var numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            numbers = numbers.Where(predicate).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static Func<int, bool> CreatePredicate(int[] divisors)
        {
            return num =>
            {
                foreach (var div in divisors)
                {
                    if (num % div != 0)
                    {
                        return false;
                    }
                }

                return true;
            };
        }
    }
}

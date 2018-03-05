using System;
using System.Linq;

namespace _8._Custom_Comparator
{
    public class StartUp
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, bool> evenNums = x => x % 2 == 0;
            Func<int, bool> oddNums = x => x % 2 != 0;

            var evenPart = inputNums.Where(evenNums).OrderBy(x => x);
            var secondPart = inputNums.Where(oddNums).OrderBy(x => x);

            var result = evenPart.Concat(secondPart);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

using System;
using System.Linq;

namespace _1._Sort_Even_Numbers
{
    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .Where(n => n % 2 == 0)
                .OrderBy(n => n);

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

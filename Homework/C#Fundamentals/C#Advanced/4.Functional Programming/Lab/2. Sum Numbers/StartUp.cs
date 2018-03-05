using System;
using System.Linq;

namespace _2._Sum_Numbers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}

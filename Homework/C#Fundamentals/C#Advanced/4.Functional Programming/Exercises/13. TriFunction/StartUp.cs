using System;
using System.Collections.Generic;
using System.Linq;

namespace _13._TriFunction
{
    public class StartUp
    {
        public static void Main()
        {
            int sum = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            var filter = CreateFilter(sum);

            Console.WriteLine(names.FirstOrDefault(filter));
        }

        private static Func<string, bool> CreateFilter(int sum)
        {
            return name => name.ToCharArray().Sum(c => c) >= sum;
        }
    }
}

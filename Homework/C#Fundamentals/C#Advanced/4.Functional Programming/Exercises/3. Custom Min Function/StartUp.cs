using System;
using System.Linq;

namespace _3._Custom_Min_Function
{
    public class StartUp
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> func = n => n.Min();

            Console.WriteLine(func.Invoke(inputNums));
        }
    }
}

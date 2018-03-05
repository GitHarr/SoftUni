using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Reverse_And_Exclude
{
    public class StartUp
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> isWithoutReminder = x => x % n != 0;
            List<int> result = new List<int>();
            
            inputNums = inputNums.Reverse().ToArray();

            for (int i = 0; i < inputNums.Length; i++)
            {
                if (isWithoutReminder.Invoke(inputNums[i]))
                {
                    result.Add(inputNums[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

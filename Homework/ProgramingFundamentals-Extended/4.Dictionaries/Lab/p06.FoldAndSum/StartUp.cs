namespace p06.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int k = list.Count / 4;

            var leftSide = list.Take(k).Reverse().ToList();
            var mainList = list.Skip(k).Take(2 * k).ToList();
            var rightSide = list.Skip(3 * k).Take(k).Reverse().ToList();

            var upperList = leftSide.Concat(rightSide).ToList();

            List<int> result = new List<int>();
            for (int i = 0; i < 2 * k; i++)
            {
                result.Add(upperList[i] + mainList[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

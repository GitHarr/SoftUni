namespace p06.FoldAndSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            int[] row1Left = arr.Take(k).Reverse().ToArray();
            int[] row1Right = arr.Reverse().Take(k).ToArray();
            int[] row1 = row1Left.Concat(row1Right).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();

            int[] sumArr = new int[row1.Length];

            for (int i = 0; i < row1.Length; i++)
            {
                sumArr[i] = row1[i] + row2[i];
            }

            Console.WriteLine(string.Join(" ", sumArr));

        }
    }
}

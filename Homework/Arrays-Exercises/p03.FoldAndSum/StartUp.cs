namespace p03.FoldAndSum
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = firstArray.Length / 4;

            int[] thirdFoldedArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                thirdFoldedArray[i] = firstArray[k - 1 - i];
                thirdFoldedArray[k + i] = firstArray[4 * k - 1 - i];
            }

            int[] secondArray = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                secondArray[i] = firstArray[i + k];
                Console.Write($"{thirdFoldedArray[i] + secondArray[i]} ");
            }

            Console.WriteLine();
        }
    }
}

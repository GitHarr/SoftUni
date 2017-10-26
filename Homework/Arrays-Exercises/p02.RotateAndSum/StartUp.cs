namespace p02.RotateAndSum
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sumResult = new int[arr.Length];

            for (int i = 0; i < k; i++)
            {
                int last = arr.Last();

                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }

                arr[0] = last;

                for (int m = 0; m < sumResult.Length; m++)
                {
                    sumResult[m] += arr[m];
                }
            }

            Console.WriteLine(string.Join(" ", sumResult));
        }
    }
}
